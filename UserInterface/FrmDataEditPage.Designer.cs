
namespace UserInterface
{
    partial class FrmDataEditPage
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
            this.BtnCancel = new DataAccess.Concrete.RjButton();
            this.DtgList = new System.Windows.Forms.DataGridView();
            this.TxtBraceletSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBigDiameter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSmallDiameter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdd = new DataAccess.Concrete.RjButton();
            this.BtnUpdate = new DataAccess.Concrete.RjButton();
            this.BtnDelete = new DataAccess.Concrete.RjButton();
            this.BtnClear = new DataAccess.Concrete.RjButton();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgList)).BeginInit();
            this.SuspendLayout();
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
            this.BtnCancel.Location = new System.Drawing.Point(689, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(61, 56);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "X";
            this.BtnCancel.TextColor = System.Drawing.Color.Brown;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DtgList
            // 
            this.DtgList.AllowUserToAddRows = false;
            this.DtgList.AllowUserToDeleteRows = false;
            this.DtgList.AllowUserToOrderColumns = true;
            this.DtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgList.Location = new System.Drawing.Point(18, 17);
            this.DtgList.MultiSelect = false;
            this.DtgList.Name = "DtgList";
            this.DtgList.ReadOnly = true;
            this.DtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgList.Size = new System.Drawing.Size(394, 330);
            this.DtgList.TabIndex = 2;
            this.DtgList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgList_CellMouseClick);
            // 
            // TxtBraceletSize
            // 
            this.TxtBraceletSize.BackColor = System.Drawing.Color.White;
            this.TxtBraceletSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBraceletSize.Location = new System.Drawing.Point(537, 132);
            this.TxtBraceletSize.Name = "TxtBraceletSize";
            this.TxtBraceletSize.Size = new System.Drawing.Size(192, 23);
            this.TxtBraceletSize.TabIndex = 6;
            this.TxtBraceletSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBraceletSize_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bracelet Size:";
            // 
            // TxtBigDiameter
            // 
            this.TxtBigDiameter.BackColor = System.Drawing.Color.White;
            this.TxtBigDiameter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBigDiameter.Location = new System.Drawing.Point(537, 161);
            this.TxtBigDiameter.Name = "TxtBigDiameter";
            this.TxtBigDiameter.Size = new System.Drawing.Size(192, 23);
            this.TxtBigDiameter.TabIndex = 8;
            this.TxtBigDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBigDiameter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Big Diameter:";
            // 
            // TxtSmallDiameter
            // 
            this.TxtSmallDiameter.BackColor = System.Drawing.Color.White;
            this.TxtSmallDiameter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSmallDiameter.Location = new System.Drawing.Point(537, 190);
            this.TxtSmallDiameter.Name = "TxtSmallDiameter";
            this.TxtSmallDiameter.Size = new System.Drawing.Size(192, 23);
            this.TxtSmallDiameter.TabIndex = 10;
            this.TxtSmallDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSmallDiameter_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Small Diameter:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnAdd.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.BtnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAdd.BorderRadius = 31;
            this.BtnAdd.BorderSize = 0;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(12, 398);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 39);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextColor = System.Drawing.Color.White;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnUpdate.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.BtnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnUpdate.BorderRadius = 31;
            this.BtnUpdate.BorderSize = 0;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(112, 398);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(94, 39);
            this.BtnUpdate.TabIndex = 15;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.TextColor = System.Drawing.Color.White;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnDelete.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.BtnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDelete.BorderRadius = 31;
            this.BtnDelete.BorderSize = 0;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(212, 398);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 39);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextColor = System.Drawing.Color.White;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnClear.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.BtnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnClear.BorderRadius = 31;
            this.BtnClear.BorderSize = 0;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(312, 398);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(94, 39);
            this.BtnClear.TabIndex = 17;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextColor = System.Drawing.Color.White;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total Recort:";
            // 
            // LblTop
            // 
            this.LblTop.AutoSize = true;
            this.LblTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTop.Location = new System.Drawing.Point(98, 359);
            this.LblTop.Name = "LblTop";
            this.LblTop.Size = new System.Drawing.Size(19, 12);
            this.LblTop.TabIndex = 19;
            this.LblTop.Text = "00";
            // 
            // FrmDataEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(753, 465);
            this.Controls.Add(this.LblTop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtSmallDiameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBigDiameter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBraceletSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgList);
            this.Controls.Add(this.BtnCancel);
            this.Name = "FrmDataEditPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDataEditPage";
            this.Load += new System.EventHandler(this.FrmDataEditPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataAccess.Concrete.RjButton BtnCancel;
        private System.Windows.Forms.DataGridView DtgList;
        private System.Windows.Forms.TextBox TxtBraceletSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBigDiameter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSmallDiameter;
        private System.Windows.Forms.Label label3;
        private DataAccess.Concrete.RjButton BtnAdd;
        private DataAccess.Concrete.RjButton BtnUpdate;
        private DataAccess.Concrete.RjButton BtnDelete;
        private DataAccess.Concrete.RjButton BtnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTop;
    }
}