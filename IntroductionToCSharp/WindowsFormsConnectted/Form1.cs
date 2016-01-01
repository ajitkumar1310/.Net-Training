using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;namespace WindowsFormsConnectted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\j1011718.JDA\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from EmpTable";
                cmd.Connection = con;
                con.Open();               
                
                DataTable dt=new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                
                con.Close();

            }
        }

        private void UpdateEmp_Click(object sender, EventArgs e)
        {

            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\j1011718.JDA\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            int ID = dataGridView1.SelectedCells[0].RowIndex;
            int EmpID =(int) dataGridView1.Rows[ID].Cells[0].Value;
            string EmpName= dataGridView1.Rows[ID].Cells[1].Value.ToString();
            String EmpCity= dataGridView1.Rows[ID].Cells[2].Value.ToString();
            using (SqlConnection con = new SqlConnection(constr))
            {

                //updated the table by opening and closing connection
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Update EmpTable Set EmpName='"+EmpName+"',EmpCity='"+EmpCity+"' where EmpID="+EmpID;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                

                

            }

        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\j1011718.JDA\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            int ID = dataGridView1.SelectedCells[0].RowIndex;
            int EmpID = (int)dataGridView1.Rows[ID].Cells[0].Value;
            string EmpName = dataGridView1.Rows[ID].Cells[1].Value.ToString();
            String EmpCity = dataGridView1.Rows[ID].Cells[2].Value.ToString();
            using (SqlConnection con = new SqlConnection(constr))
            {

                //updated the table by opening and closing connection
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete EmpTable where EmpID='" + EmpID + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



            }
        }

        private void BtnInsertRecord_Click(object sender, EventArgs e)
        {

            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\j1011718.JDA\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
           
            int EmpID = int.Parse(txtEmpID.Text);
            string EmpName = txtEmpName.Text;
            String EmpCity = txtEmpCity.Text;
            using (SqlConnection con = new SqlConnection(constr))
            {

                //updated the table by opening and closing connection
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into EmpTable values('"+EmpID+"','"+EmpName+ "','" +EmpCity+ "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



            }
        }

        private void btnGetEmployees_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnGetAverage_Click(object sender, EventArgs e)
        {

            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ajitk\OneDrive\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "AverageProcedure";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@average",0);
                param1.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param1);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = param1.Value.ToString();




            }



                //string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ajitk\OneDrive\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
                //using (SqlConnection con = new SqlConnection(constr))
                //{
                //    SqlCommand cmd = new SqlCommand();
                //    cmd.CommandText = "AverageProcedure";
                //    cmd.Connection = con;
                //    cmd.CommandType = CommandType.StoredProcedure;
                //    SqlParameter param1 = new SqlParameter();
                //    param1.ParameterName = "@average";
                //    param1.Value = 0;
                //    param1.Direction = ParameterDirection.Output;
                //    cmd.Parameters.Add(param1);
                //    con.Open();
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //    textBox1.Text = param1.Value.ToString();
                //}


            }
    }
}
