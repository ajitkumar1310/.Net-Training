namespace WinFormDisconnected_Queries
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
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInsertEmp = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // btnGetEmployees
            // 
            this.btnGetEmployees.Location = new System.Drawing.Point(55, 297);
            this.btnGetEmployees.Name = "btnGetEmployees";
            this.btnGetEmployees.Size = new System.Drawing.Size(138, 29);
            this.btnGetEmployees.TabIndex = 1;
            this.btnGetEmployees.Text = "Get Employees";
            this.btnGetEmployees.UseVisualStyleBackColor = true;
            this.btnGetEmployees.Click += new System.EventHandler(this.btnGetEmployees_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(548, 121);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(165, 23);
            this.btnUpdateEmployee.TabIndex = 2;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "EmpCity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "EmpName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "EmpId";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(322, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(184, 53);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // btnInsertEmp
            // 
            this.btnInsertEmp.Location = new System.Drawing.Point(548, 51);
            this.btnInsertEmp.Name = "btnInsertEmp";
            this.btnInsertEmp.Size = new System.Drawing.Size(165, 23);
            this.btnInsertEmp.TabIndex = 11;
            this.btnInsertEmp.Text = "InsertEmployee";
            this.btnInsertEmp.UseVisualStyleBackColor = true;
            this.btnInsertEmp.Click += new System.EventHandler(this.btnInsertEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(548, 200);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(165, 23);
            this.btnDeleteEmp.TabIndex = 18;
            this.btnDeleteEmp.Text = "Delete Employee";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(281, 297);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(219, 23);
            this.btnSaveChanges.TabIndex = 19;
            this.btnSaveChanges.Text = "Save Changes To DB";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 384);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnDeleteEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnInsertEmp);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnGetEmployees);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Disconnected-Queries";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetEmployees;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInsertEmp;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}

