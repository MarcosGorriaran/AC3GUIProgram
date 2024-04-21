namespace AC3GUIProgram.View
{
    partial class InsertNotice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMsg = new Label();
            btnConfirm = new Button();
            picGoodSymbol = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picGoodSymbol).BeginInit();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(67, 9);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(195, 30);
            lblMsg.TabIndex = 0;
            lblMsg.Text = "La informacio ha sigut almacenat al\r\nservidor de base de dades";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(187, 54);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "D'acord";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // picGoodSymbol
            // 
            picGoodSymbol.Location = new Point(7, 9);
            picGoodSymbol.Name = "picGoodSymbol";
            picGoodSymbol.Size = new Size(54, 68);
            picGoodSymbol.TabIndex = 2;
            picGoodSymbol.TabStop = false;
            // 
            // InsertNotice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 89);
            Controls.Add(picGoodSymbol);
            Controls.Add(btnConfirm);
            Controls.Add(lblMsg);
            Name = "InsertNotice";
            Text = "Notificacio";
            Load += InsertNotice_Load;
            ((System.ComponentModel.ISupportInitialize)picGoodSymbol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsg;
        private Button btnConfirm;
        private PictureBox picGoodSymbol;
    }
}