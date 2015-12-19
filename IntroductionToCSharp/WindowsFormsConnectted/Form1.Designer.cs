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
            this.btnGetEmployees = new System.Windows.Forms.Button();
            this.btnInsertEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpCity = new System.Windows.Forms.TextBox();
            this.btnDeleteEmployees = new System.Windows.Forms.Button();
            this.btnUpdateEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetEmployees
            // 
            this.btnGetEmployees.Location = new System.Drawing.Point(29, 271);
            this.btnGetEmployees.Name = "btnGetEmployees";
            this.btnGetEmployees.Size = new System.Drawing.Size(120, 23);
            this.btnGetEmployees.TabIndex = 1;
            this.btnGetEmployees.Text = "Get Employees";
            this.btnGetEmployees.UseVisualStyleBackColor = true;
            this.btnGetEmployees.Click += new System.EventHandler(this.btnGetEmployees_Click);
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Location = new System.Drawing.Point(430, 98);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(141, 23);
            this.btnInsertEmployee.TabIndex = 2;
            this.btnInsertEmployee.Text = "Insert Employees";
            this.btnInsertEmployee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "EmpID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EmpName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EmpCity";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(32, 54);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 20);
            this.txtEmpID.TabIndex = 6;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(169, 54);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 7;
            // 
            // txtEmpCity
            // 
            this.txtEmpCity.Location = new System.Drawing.Point(315, 54);
            this.txtEmpCity.Name = "txtEmpCity";
            this.txtEmpCity.Size = new System.Drawing.Size(100, 20);
            this.txtEmpCity.TabIndex = 8;
            // 
            // btnDeleteEmployees
            // 
            this.btnDeleteEmployees.Location = new System.Drawing.Point(430, 150);
            this.btnDeleteEmployees.Name = "btnDeleteEmployees";
            this.btnDeleteEmployees.Size = new System.Drawing.Size(141, 23);
            this.btnDeleteEmployees.TabIndex = 9;
            this.btnDeleteEmployees.Text = "Delete Employees";
            this.btnDeleteEmployees.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployees
            // 
            this.btnUpdateEmployees.Location = new System.Drawing.Point(430, 211);
            this.btnUpdateEmployees.Name = "btnUpdateEmployees";
            this.btnUpdateEmployees.Size = new System.Drawing.Size(141, 23);
            this.btnUpdateEmployees.TabIndex = 10;
            this.btnUpdateEmployees.Text = "Update Employees";
            this.btnUpdateEmployees.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 356);
            this.Controls.Add(this.btnUpdateEmployees);
            this.Controls.Add(this.btnDeleteEmployees);
            this.Controls.Add(this.txtEmpCity);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertEmployee);
            this.Controls.Add(this.btnGetEmployees);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "WindowsFormConnected";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetEmployees;
        private System.Windows.Forms.Button btnInsertEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpCity;
        private System.Windows.Forms.Button btnDeleteEmployees;
        private System.Windows.Forms.Button btnUpdateEmployees;
    }
}