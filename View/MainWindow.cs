using AC3GUIProgram.DTO;
using AC3GUIProgram.Persistance.Mapping;
using AC3GUIProgram.Persistance.Utils;
using AC3GUIProgram.View;
using Microsoft.VisualBasic;
using Npgsql;
using System.Security.Cryptography.Xml;

namespace AC3GUIProgram
{
    public partial class MainWindow : Form
    {
        const string FileInfoPath = "../../../DataFiles/WaterConsumptionOnCat.csv";
        const string FileLocationPath = "../../../DataFiles/Location.xml";
        const string CanNotBeEmpty = "The value can't be empty";
        const string InvalidFormat = "The value uses the wrong format";
        const string TrueAns = "Sí";
        const string FalseAns = "No";
        const int HighPop = 20000;
        const int LimitYear = 2050;
        private List<ConsumptionInfo> groupInfo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(FileInfoPath))
            {
                groupInfo = CRUD.CSVDeserialize<ConsumptionInfo>(sr);
            }
            CreateTable();
            CreateComboBoxContent();
            GenerateDiferenteLocations();
            CheckDBConnection();
        }
        private void CheckDBConnection()
        {
            try
            {
                using ConsumptionInfoDAO infoDBController = new ConsumptionInfoDAO();
            }
            catch (Exception)
            {
                btnDBStore.Enabled = false;
            }
        }
        private void GenerateDiferenteLocations()
        {
            HashSet<Location> locations;
            try
            {
                using (StreamReader sr = new StreamReader(FileLocationPath))
                {

                    locations = CRUD.XMLDeserialize<Location>(sr).ToHashSet();
                }
            }
            catch (FileNotFoundException)
            {
                locations = new HashSet<Location>();
            }

            foreach (ConsumptionInfo info in groupInfo)
            {
                locations.Add(info.GetLocation());
            }
            locations = locations.Distinct().ToHashSet();
            using (StreamWriter sw = new StreamWriter(FileLocationPath))
            {
                CRUD.XMLSerialize(sw, locations.OrderBy(loc => loc.LocCode).Distinct().ToList());
            }
            cmbLocName.DataSource = locations.ToList();
            cmbLocName.ValueMember = "LocCode";
            cmbLocName.DisplayMember = "LocName";
        }
        private void CreateComboBoxContent()
        {
            int minYear = groupInfo.Min(info => info.Year);

            List<int> yearList = new List<int>();

            for (int i = minYear; i <= LimitYear; i++)
            {
                yearList.Add(i);
            }

            cmbYear.DataSource = yearList;
        }
        private void CreateTable()
        {

            foreach (ConsumptionInfo element in groupInfo)
            {
                TableAddElement(element);
            }
        }
        private void TableAddElement(ConsumptionInfo element)
        {
            int row = dtgConsumptionInfo.Rows.Add();

            dtgConsumptionInfo.Rows[row].Cells[0].Value = element.Year;
            dtgConsumptionInfo.Rows[row].Cells[1].Value = element.LocCode;
            dtgConsumptionInfo.Rows[row].Cells[2].Value = element.LocName;
            dtgConsumptionInfo.Rows[row].Cells[3].Value = element.Population;
            dtgConsumptionInfo.Rows[row].Cells[4].Value = element.HouseNet;
            dtgConsumptionInfo.Rows[row].Cells[5].Value = element.EconomicAct;
            dtgConsumptionInfo.Rows[row].Cells[6].Value = element.Total;
            dtgConsumptionInfo.Rows[row].Cells[7].Value = element.HouseExpenseCapita;
        }
        private void dtgConsumptionInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            try
            {
                ConsumptionInfo actualInfo = groupInfo[row];

                lblPopBiggerThanAns.Text = ConsumptionInfoHelper.HasHighPop(actualInfo, HighPop) ? TrueAns : FalseAns;
                lblAvarageAns.Text = ConsumptionInfoHelper.GetAvgDomesticConsum(actualInfo).ToString();
                lblBiggerAns.Text = ConsumptionInfoHelper.IsHighestCapita(row, groupInfo) ? TrueAns : FalseAns;
                lblLowerAns.Text = ConsumptionInfoHelper.IsLowestCapita(row, groupInfo) ? TrueAns : FalseAns;
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            errorHandler.Clear();
            txtConsumCap.Text = string.Empty;
            txtEconomicAct.Text = string.Empty;
            txtHouseNet.Text = string.Empty;
            txtPopulation.Text = string.Empty;
            txtTotal.Text = string.Empty;
            cmbLocName.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
        }
        private bool ValidateFormValues(ConsumptionInfo fillValue)
        {
            bool error = false;

            try
            {
                fillValue.HouseExpenseCapita = Convert.ToSingle(txtConsumCap.Text);
            }
            catch (FormatException)
            {
                errorHandler.SetError(txtConsumCap, txtConsumCap.Text == string.Empty ? CanNotBeEmpty : InvalidFormat);
                error = true;
            }
            try
            {
                fillValue.EconomicAct = Convert.ToInt32(txtEconomicAct.Text);
            }
            catch (FormatException)
            {
                error = true;
                errorHandler.SetError(txtEconomicAct, txtEconomicAct.Text == string.Empty ? CanNotBeEmpty : InvalidFormat);
            }
            try
            {
                fillValue.HouseNet = Convert.ToInt32(txtHouseNet.Text);
            }
            catch (FormatException)
            {
                error = true;
                errorHandler.SetError(txtHouseNet, txtHouseNet.Text == string.Empty ? CanNotBeEmpty : InvalidFormat);
            }
            try
            {
                fillValue.Population = Convert.ToInt32(txtPopulation.Text);
            }
            catch (FormatException)
            {
                error = true;
                errorHandler.SetError(txtPopulation, txtPopulation.Text == string.Empty ? CanNotBeEmpty : InvalidFormat);
            }
            try
            {
                fillValue.Total = Convert.ToInt32(txtTotal.Text);
            }
            catch (FormatException)
            {
                error = true;
                errorHandler.SetError(txtTotal, txtTotal.Text == string.Empty ? CanNotBeEmpty : InvalidFormat);
            }
            fillValue.Year = Convert.ToInt32(cmbYear.SelectedValue);
            fillValue.LocCode = (int)cmbLocName.SelectedValue;
            fillValue.LocName = cmbLocName.Text;
            return error;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            errorHandler.Clear();
            ConsumptionInfo newInfo = new ConsumptionInfo();

            if (!ValidateFormValues(newInfo))
            {
                groupInfo.Add(newInfo);
                TableAddElement(newInfo);
                CRUD.CSVSerialize(FileInfoPath, new List<ConsumptionInfo>()
                {
                    newInfo
                });
            }

        }

        private void btnDBStore_Click(object sender, EventArgs e)
        {
            errorHandler.Clear();
            ConsumptionInfo newInfo = new ConsumptionInfo();

            if (!ValidateFormValues(newInfo))
            {
                using ConsumptionInfoDAO dbConn = new ConsumptionInfoDAO();
                try
                {
                    dbConn.Add(newInfo);
                    new InsertNotice().ShowDialog();
                }
                catch (Exception)
                {
                    errorHandler.SetError(btnDBStore, "El programa no ha pogut insertar la nova data a la base de dades.");
                }
                
            }
        }
    }
}
