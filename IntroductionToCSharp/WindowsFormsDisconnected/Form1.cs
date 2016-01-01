using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDisconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetEmp_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ajitk\OneDrive\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from EmpTable",con);
                DataSet ds = new DataSet();
                da.Fill(ds, "EmpTable");
                dataGridView1.DataSource = ds.Tables["EmpTable"];
              //  ds.Tables["EmpTable"];
                

            }
        }
    }
}
