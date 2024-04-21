namespace AC3GUIProgram.View
{
    public partial class InsertNotice : Form
    {
        public InsertNotice()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertNotice_Load(object sender, EventArgs e)
        {
            picGoodSymbol.Image = System.Drawing.SystemIcons.Information.ToBitmap();
        }
    }
}
