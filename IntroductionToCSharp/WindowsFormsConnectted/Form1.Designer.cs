namespace WindowsFormsConnectted
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateEmp = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpCity = new System.Windows.Forms.TextBox();
            this.BtnInsertRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GetEmployees";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateEmp
            // 
            this.UpdateEmp.Location = new System.Drawing.Point(510, 185);
            this.UpdateEmp.Name = "UpdateEmp";
            this.UpdateEmp.Size = new System.Drawing.Size(98, 23);
            this.UpdateEmp.TabIndex = 2;
            this.UpdateEmp.Text = "Update Emp";
            this.UpdateEmp.UseVisualStyleBackColor = true;
            this.UpdateEmp.Click += new System.EventHandler(this.UpdateEmp_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.Location = new System.Drawing.Point(510, 246);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(98, 23);
            this.DeleteRecord.TabIndex = 3;
            this.DeleteRecord.Text = "DeleteRecord";
            this.DeleteRecord.UseVisualStyleBackColor = true;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(22, 79);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 20);
            this.txtEmpID.TabIndex = 4;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(205, 79);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 5;
            // 
            // txtEmpCity
            // 
            this.txtEmpCity.Location = new System.Drawing.Point(384, 79);
            this.txtEmpCity.Name = "txtEmpCity";
            this.txtEmpCity.Size = new System.Drawing.Size(100, 20);
            this.txtEmpCity.TabIndex = 6;
            // 
            // BtnInsertRecord
            // 
            this.BtnInsertRecord.Location = new System.Drawing.Point(510, 119);
            this.BtnInsertRecord.Name = "BtnInsertRecord";
            this.BtnInsertRecord.Size = new System.Drawing.Size(94, 23);
            this.BtnInsertRecord.TabIndex = 7;
            this.BtnInsertRecord.Text = "InsertRecord";
            this.BtnInsertRecord.UseVisualStyleBackColor = true;
            this.BtnInsertRecord.Click += new System.EventHandler(this.BtnInsertRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "EmpID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "EmpName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "EmpCity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnInsertRecord);
            this.Controls.Add(this.txtEmpCity);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.UpdateEmp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "WinFormConnected";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateEmp;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpCity;
        private System.Windows.Forms.Button BtnInsertRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

