using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsDisconnected
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetEmployees_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Johannes Chauke\Documents\EmpNewDB.mdf ""; ; Integrated Security = True; Connect Timeout = 30";
            using (SqlDataAdapter da = new SqlDataAdapter("Select * from EmpTable",constr))
            {
                
                da.Fill(ds, "EmpTable");
                dataGridView1.DataSource = ds.Tables["EmpTable"];
                
                ds.Tables["EmpTable"].Rows.Add(6, "XXX", "Bang");
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds.Tables["EmpTable"]);

            }
        }
    }
}
