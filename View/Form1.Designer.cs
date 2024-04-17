namespace AC3GUIProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtTotal = new TextBox();
            txtConsumCap = new TextBox();
            txtEconomicAct = new TextBox();
            txtHouseNet = new TextBox();
            txtPopulation = new TextBox();
            cmbLocName = new ComboBox();
            cmbYear = new ComboBox();
            lblTotal = new Label();
            lblConsumCap = new Label();
            lblEconomicAct = new Label();
            lblHouseNet = new Label();
            lblPopulation = new Label();
            lblLoc = new Label();
            lblYear = new Label();
            groupBox2 = new GroupBox();
            lblLowerAns = new Label();
            lblBiggerAns = new Label();
            lblAvarageAns = new Label();
            lblPopBiggerThanAns = new Label();
            label1 = new Label();
            lblBiggest = new Label();
            lblAvarage = new Label();
            lblPopBiggerThan = new Label();
            dtgConsumptionInfo = new DataGridView();
            Year = new DataGridViewTextBoxColumn();
            LocCode = new DataGridViewTextBoxColumn();
            LocName = new DataGridViewTextBoxColumn();
            Population = new DataGridViewTextBoxColumn();
            HouseNet = new DataGridViewTextBoxColumn();
            EconomicAct = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            HouseExpenseCapita = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            btnClear = new Button();
            btnSend = new Button();
            errorHandler = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgConsumptionInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorHandler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtConsumCap);
            groupBox1.Controls.Add(txtEconomicAct);
            groupBox1.Controls.Add(txtHouseNet);
            groupBox1.Controls.Add(txtPopulation);
            groupBox1.Controls.Add(cmbLocName);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(lblConsumCap);
            groupBox1.Controls.Add(lblEconomicAct);
            groupBox1.Controls.Add(lblHouseNet);
            groupBox1.Controls.Add(lblPopulation);
            groupBox1.Controls.Add(lblLoc);
            groupBox1.Controls.Add(lblYear);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(430, 128);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 13;
            // 
            // txtConsumCap
            // 
            txtConsumCap.Location = new Point(430, 96);
            txtConsumCap.Name = "txtConsumCap";
            txtConsumCap.Size = new Size(100, 23);
            txtConsumCap.TabIndex = 12;
            // 
            // txtEconomicAct
            // 
            txtEconomicAct.Location = new Point(144, 131);
            txtEconomicAct.Name = "txtEconomicAct";
            txtEconomicAct.Size = new Size(100, 23);
            txtEconomicAct.TabIndex = 11;
            // 
            // txtHouseNet
            // 
            txtHouseNet.Location = new Point(16, 131);
            txtHouseNet.Name = "txtHouseNet";
            txtHouseNet.Size = new Size(100, 23);
            txtHouseNet.TabIndex = 10;
            // 
            // txtPopulation
            // 
            txtPopulation.Location = new Point(271, 36);
            txtPopulation.Name = "txtPopulation";
            txtPopulation.Size = new Size(100, 23);
            txtPopulation.TabIndex = 9;
            // 
            // cmbLocName
            // 
            cmbLocName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocName.FormattingEnabled = true;
            cmbLocName.Location = new Point(144, 36);
            cmbLocName.Name = "cmbLocName";
            cmbLocName.Size = new Size(121, 23);
            cmbLocName.TabIndex = 8;
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(16, 36);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(121, 23);
            cmbYear.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(307, 131);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // lblConsumCap
            // 
            lblConsumCap.AutoSize = true;
            lblConsumCap.Location = new Point(307, 89);
            lblConsumCap.Name = "lblConsumCap";
            lblConsumCap.Size = new Size(104, 30);
            lblConsumCap.TabIndex = 5;
            lblConsumCap.Text = "Consum domèstic\r\nper càpita";
            // 
            // lblEconomicAct
            // 
            lblEconomicAct.AutoSize = true;
            lblEconomicAct.Location = new Point(144, 87);
            lblEconomicAct.Name = "lblEconomicAct";
            lblEconomicAct.Size = new Size(134, 30);
            lblEconomicAct.TabIndex = 4;
            lblEconomicAct.Text = "Activitats econòmiques \r\ni fonts pròpies";
            lblEconomicAct.Click += label5_Click;
            // 
            // lblHouseNet
            // 
            lblHouseNet.AutoSize = true;
            lblHouseNet.Location = new Point(16, 92);
            lblHouseNet.Name = "lblHouseNet";
            lblHouseNet.Size = new Size(88, 15);
            lblHouseNet.TabIndex = 3;
            lblHouseNet.Text = "Domèstic xarxa";
            // 
            // lblPopulation
            // 
            lblPopulation.AutoSize = true;
            lblPopulation.Location = new Point(271, 19);
            lblPopulation.Name = "lblPopulation";
            lblPopulation.Size = new Size(53, 15);
            lblPopulation.TabIndex = 2;
            lblPopulation.Text = "Població";
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Location = new Point(144, 19);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(55, 15);
            lblLoc.TabIndex = 1;
            lblLoc.Text = "Comarca";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(16, 18);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(28, 15);
            lblYear.TabIndex = 0;
            lblYear.Text = "Any";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblLowerAns);
            groupBox2.Controls.Add(lblBiggerAns);
            groupBox2.Controls.Add(lblAvarageAns);
            groupBox2.Controls.Add(lblPopBiggerThanAns);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblBiggest);
            groupBox2.Controls.Add(lblAvarage);
            groupBox2.Controls.Add(lblPopBiggerThan);
            groupBox2.Location = new Point(588, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 204);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            // 
            // lblLowerAns
            // 
            lblLowerAns.AutoSize = true;
            lblLowerAns.Location = new Point(223, 92);
            lblLowerAns.Name = "lblLowerAns";
            lblLowerAns.Size = new Size(29, 15);
            lblLowerAns.TabIndex = 7;
            lblLowerAns.Text = "N/A";
            // 
            // lblBiggerAns
            // 
            lblBiggerAns.AutoSize = true;
            lblBiggerAns.Location = new Point(220, 68);
            lblBiggerAns.Name = "lblBiggerAns";
            lblBiggerAns.Size = new Size(29, 15);
            lblBiggerAns.TabIndex = 6;
            lblBiggerAns.Text = "N/A";
            // 
            // lblAvarageAns
            // 
            lblAvarageAns.AutoSize = true;
            lblAvarageAns.Location = new Point(154, 44);
            lblAvarageAns.Name = "lblAvarageAns";
            lblAvarageAns.Size = new Size(29, 15);
            lblAvarageAns.TabIndex = 5;
            lblAvarageAns.Text = "N/A";
            // 
            // lblPopBiggerThanAns
            // 
            lblPopBiggerThanAns.AutoSize = true;
            lblPopBiggerThanAns.Location = new Point(143, 18);
            lblPopBiggerThanAns.Name = "lblPopBiggerThanAns";
            lblPopBiggerThanAns.Size = new Size(29, 15);
            lblPopBiggerThanAns.TabIndex = 4;
            lblPopBiggerThanAns.Text = "N/A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 92);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 3;
            label1.Text = "Consum domèstic per càpita més baix: ";
            // 
            // lblBiggest
            // 
            lblBiggest.AutoSize = true;
            lblBiggest.Location = new Point(11, 68);
            lblBiggest.Name = "lblBiggest";
            lblBiggest.Size = new Size(203, 15);
            lblBiggest.TabIndex = 2;
            lblBiggest.Text = "Consum domèstic per càpita més alt:";
            // 
            // lblAvarage
            // 
            lblAvarage.AutoSize = true;
            lblAvarage.Location = new Point(11, 44);
            lblAvarage.Name = "lblAvarage";
            lblAvarage.Size = new Size(137, 15);
            lblAvarage.TabIndex = 1;
            lblAvarage.Text = "Consum domèstic mitjà:";
            // 
            // lblPopBiggerThan
            // 
            lblPopBiggerThan.AutoSize = true;
            lblPopBiggerThan.Location = new Point(11, 19);
            lblPopBiggerThan.Name = "lblPopBiggerThan";
            lblPopBiggerThan.Size = new Size(126, 15);
            lblPopBiggerThan.TabIndex = 0;
            lblPopBiggerThan.Text = "Població > 20000 hab.:";
            // 
            // dtgConsumptionInfo
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgConsumptionInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgConsumptionInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgConsumptionInfo.Columns.AddRange(new DataGridViewColumn[] { Year, LocCode, LocName, Population, HouseNet, EconomicAct, Total, HouseExpenseCapita });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgConsumptionInfo.DefaultCellStyle = dataGridViewCellStyle2;
            dtgConsumptionInfo.Location = new Point(12, 288);
            dtgConsumptionInfo.Name = "dtgConsumptionInfo";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgConsumptionInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgConsumptionInfo.RowHeadersWidth = 82;
            dtgConsumptionInfo.Size = new Size(843, 150);
            dtgConsumptionInfo.TabIndex = 2;
            dtgConsumptionInfo.CellClick += dtgConsumptionInfo_CellClick;
            // 
            // Year
            // 
            Year.HeaderText = "Any";
            Year.MinimumWidth = 10;
            Year.Name = "Year";
            Year.Width = 200;
            // 
            // LocCode
            // 
            LocCode.HeaderText = "Codi comarca";
            LocCode.MinimumWidth = 10;
            LocCode.Name = "LocCode";
            LocCode.Width = 200;
            // 
            // LocName
            // 
            LocName.HeaderText = "Comarca";
            LocName.MinimumWidth = 10;
            LocName.Name = "LocName";
            LocName.Width = 200;
            // 
            // Population
            // 
            Population.HeaderText = "Poblacio";
            Population.MinimumWidth = 10;
            Population.Name = "Population";
            Population.Width = 200;
            // 
            // HouseNet
            // 
            HouseNet.HeaderText = "Domèstic xarxa";
            HouseNet.MinimumWidth = 10;
            HouseNet.Name = "HouseNet";
            HouseNet.Width = 200;
            // 
            // EconomicAct
            // 
            EconomicAct.HeaderText = "Avtivitats económiques i fonts própies";
            EconomicAct.MinimumWidth = 10;
            EconomicAct.Name = "EconomicAct";
            EconomicAct.Width = 200;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 10;
            Total.Name = "Total";
            Total.Width = 200;
            // 
            // HouseExpenseCapita
            // 
            HouseExpenseCapita.HeaderText = "Consum domèstic per càpita";
            HouseExpenseCapita.MinimumWidth = 10;
            HouseExpenseCapita.Name = "HouseExpenseCapita";
            HouseExpenseCapita.Width = 200;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(369, 220);
            btnClear.Margin = new Padding(2, 1, 2, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 22);
            btnClear.TabIndex = 3;
            btnClear.Text = "Netejar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(467, 220);
            btnSend.Margin = new Padding(2, 1, 2, 1);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(81, 22);
            btnSend.TabIndex = 4;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // errorHandler
            // 
            errorHandler.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 450);
            Controls.Add(btnSend);
            Controls.Add(btnClear);
            Controls.Add(dtgConsumptionInfo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Gestió de dades demogràfiques de regions";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgConsumptionInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorHandler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtgConsumptionInfo;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn LocCode;
        private DataGridViewTextBoxColumn LocName;
        private DataGridViewTextBoxColumn Population;
        private DataGridViewTextBoxColumn HouseNet;
        private DataGridViewTextBoxColumn EconomicAct;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn HouseExpenseCapita;
        private Label lblTotal;
        private Label lblConsumCap;
        private Label lblEconomicAct;
        private Label lblHouseNet;
        private Label lblPopulation;
        private Label lblLoc;
        private Label lblYear;
        private TextBox txtTotal;
        private TextBox txtConsumCap;
        private TextBox txtEconomicAct;
        private TextBox txtHouseNet;
        private TextBox txtPopulation;
        private ComboBox cmbLocName;
        private ComboBox cmbYear;
        private BindingSource bindingSource1;
        private Label lblPopBiggerThan;
        private Label lblPopBiggerThanAns;
        private Label label1;
        private Label lblBiggest;
        private Label lblAvarage;
        private Label lblLowerAns;
        private Label lblBiggerAns;
        private Label lblAvarageAns;
        private Button btnClear;
        private Button btnSend;
        private ErrorProvider errorHandler;
    }
}
