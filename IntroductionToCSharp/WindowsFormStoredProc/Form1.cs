using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormStoredProc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetEmployees_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\j1011718.JDA\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GetEmpProcedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\j1011718.JDA\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            int ID = dataGridView1.SelectedCells[0].RowIndex;
            int EmpID = (int)dataGridView1.Rows[ID].Cells[0].Value;
            string EmpName = dataGridView1.Rows[ID].Cells[1].Value.ToString();
            String EmpCity = dataGridView1.Rows[ID].Cells[2].Value.ToString();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UpdateEmpProcedure";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                SqlParameter param1 = new SqlParameter("@EmpID", EmpID);
                
                cmd.Parameters.Add(param1);
                SqlParameter param2 = new SqlParameter("@EmpName", EmpName);
                cmd.Parameters.Add(param2);
                SqlParameter param3 = new SqlParameter("@EmpCity", EmpCity);
                cmd.Parameters.Add(param3);
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\j1011718.JDA\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            int ID = dataGridView1.SelectedCells[0].RowIndex;
            int EmpID = (int)dataGridView1.Rows[ID].Cells[0].Value;
            using (SqlConnection con=new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DeletEmpProcedure";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param1 = new SqlParameter("@EmpID", EmpID);
                cmd.Parameters.Add(param1);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertEmp_Click(object sender, EventArgs e)
        {
            int EmpId = int.Parse(textBox1.Text);
            string EmpName = txtEmpName.Text;
            string EmpCity = textBox3.Text;
            string constr =  @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\j1011718.JDA\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con=new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "InsertEmpProcedure";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@EmpID", EmpId);
                cmd.Parameters.Add(param1);
                SqlParameter param2 = new SqlParameter("@EmpName", EmpName);
                cmd.Parameters.Add(param2);
                SqlParameter param3 = new SqlParameter("@EmpCity", EmpCity);
                cmd.Parameters.Add(param3);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";


            }
        }
    }
}
