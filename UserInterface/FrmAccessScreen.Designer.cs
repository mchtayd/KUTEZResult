
namespace UserInterface
{
    partial class FrmAccessScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccessScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBraceletSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblBigDiameter = new System.Windows.Forms.Label();
            this.LblSmallDiameter = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblPerimeterResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCalculate = new DataAccess.Concrete.RjButton();
            this.BtnSentServer = new DataAccess.Concrete.RjButton();
            this.BtnCancel = new DataAccess.Concrete.RjButton();
            this.BtnDataEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbDataType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bracelet Size:";
            // 
            // TxtBraceletSize
            // 
            this.TxtBraceletSize.BackColor = System.Drawing.Color.White;
            this.TxtBraceletSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBraceletSize.Location = new System.Drawing.Point(250, 227);
            this.TxtBraceletSize.Name = "TxtBraceletSize";
            this.TxtBraceletSize.Size = new System.Drawing.Size(192, 23);
            this.TxtBraceletSize.TabIndex = 4;
            this.TxtBraceletSize.TextChanged += new System.EventHandler(this.TxtBraceletSize_TextChanged);
            this.TxtBraceletSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBraceletSize_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Big Diameter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oval Bracelet Perimeter Calculator";
            // 
            // LblBigDiameter
            // 
            this.LblBigDiameter.AutoSize = true;
            this.LblBigDiameter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBigDiameter.Location = new System.Drawing.Point(250, 311);
            this.LblBigDiameter.Name = "LblBigDiameter";
            this.LblBigDiameter.Size = new System.Drawing.Size(23, 15);
            this.LblBigDiameter.TabIndex = 7;
            this.LblBigDiameter.Text = "00";
            // 
            // LblSmallDiameter
            // 
            this.LblSmallDiameter.AutoSize = true;
            this.LblSmallDiameter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSmallDiameter.Location = new System.Drawing.Point(429, 311);
            this.LblSmallDiameter.Name = "LblSmallDiameter";
            this.LblSmallDiameter.Size = new System.Drawing.Size(23, 15);
            this.LblSmallDiameter.TabIndex = 9;
            this.LblSmallDiameter.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Small Diameter:";
            // 
            // LblPerimeterResult
            // 
            this.LblPerimeterResult.AutoSize = true;
            this.LblPerimeterResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPerimeterResult.Location = new System.Drawing.Point(301, 402);
            this.LblPerimeterResult.Name = "LblPerimeterResult";
            this.LblPerimeterResult.Size = new System.Drawing.Size(28, 18);
            this.LblPerimeterResult.TabIndex = 11;
            this.LblPerimeterResult.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Perimeter Result:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnCalculate.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.BtnCalculate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCalculate.BorderRadius = 31;
            this.BtnCalculate.BorderSize = 0;
            this.BtnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculate.FlatAppearance.BorderSize = 0;
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.ForeColor = System.Drawing.Color.White;
            this.BtnCalculate.Location = new System.Drawing.Point(304, 339);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(138, 39);
            this.BtnCalculate.TabIndex = 13;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.TextColor = System.Drawing.Color.White;
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnSentServer
            // 
            this.BtnSentServer.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnSentServer.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.BtnSentServer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSentServer.BorderRadius = 31;
            this.BtnSentServer.BorderSize = 0;
            this.BtnSentServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSentServer.FlatAppearance.BorderSize = 0;
            this.BtnSentServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSentServer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSentServer.ForeColor = System.Drawing.Color.White;
            this.BtnSentServer.Location = new System.Drawing.Point(304, 259);
            this.BtnSentServer.Name = "BtnSentServer";
            this.BtnSentServer.Size = new System.Drawing.Size(138, 39);
            this.BtnSentServer.TabIndex = 1;
            this.BtnSentServer.Text = "Sent To Server";
            this.BtnSentServer.TextColor = System.Drawing.Color.White;
            this.BtnSentServer.UseVisualStyleBackColor = false;
            this.BtnSentServer.Click += new System.EventHandler(this.BtnSentServer_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Azure;
            this.BtnCancel.BackgroundColor = System.Drawing.Color.Azure;
            this.BtnCancel.BorderColor = System.Drawing.Color.Azure;
            this.BtnCancel.BorderRadius = 34;
            this.BtnCancel.BorderSize = 0;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCancel.ForeColor = System.Drawing.Color.Brown;
            this.BtnCancel.Location = new System.Drawing.Point(533, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(61, 56);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "X";
            this.BtnCancel.TextColor = System.Drawing.Color.Brown;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDataEdit
            // 
            this.BtnDataEdit.BackColor = System.Drawing.Color.Brown;
            this.BtnDataEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDataEdit.FlatAppearance.BorderSize = 0;
            this.BtnDataEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDataEdit.ForeColor = System.Drawing.Color.White;
            this.BtnDataEdit.Location = new System.Drawing.Point(448, 227);
            this.BtnDataEdit.Name = "BtnDataEdit";
            this.BtnDataEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnDataEdit.TabIndex = 14;
            this.BtnDataEdit.Text = "Data Edit";
            this.BtnDataEdit.UseVisualStyleBackColor = false;
            this.BtnDataEdit.Visible = false;
            this.BtnDataEdit.Click += new System.EventHandler(this.BtnDataEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data Type:";
            // 
            // CmbDataType
            // 
            this.CmbDataType.BackColor = System.Drawing.Color.White;
            this.CmbDataType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.CmbDataType.FormattingEnabled = true;
            this.CmbDataType.Items.AddRange(new object[] {
            "API",
            "MSSQL"});
            this.CmbDataType.Location = new System.Drawing.Point(250, 189);
            this.CmbDataType.Name = "CmbDataType";
            this.CmbDataType.Size = new System.Drawing.Size(97, 23);
            this.CmbDataType.TabIndex = 16;
            this.CmbDataType.Text = "API";
            this.CmbDataType.SelectedIndexChanged += new System.EventHandler(this.CmbDataType_SelectedIndexChanged);
            // 
            // FrmAccessScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(596, 459);
            this.Controls.Add(this.CmbDataType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnDataEdit);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblPerimeterResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblSmallDiameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblBigDiameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBraceletSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSentServer);
            this.Controls.Add(this.BtnCancel);
            this.Name = "FrmAccessScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAccessScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAccessScreen_FormClosing);
            this.Load += new System.EventHandler(this.FrmAccessScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataAccess.Concrete.RjButton BtnCancel;
        private DataAccess.Concrete.RjButton BtnSentServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBraceletSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblBigDiameter;
        private System.Windows.Forms.Label LblSmallDiameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblPerimeterResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataAccess.Concrete.RjButton BtnCalculate;
        private System.Windows.Forms.Button BtnDataEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbDataType;
    }
}