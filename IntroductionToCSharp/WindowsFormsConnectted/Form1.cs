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

namespace WindowsFormsConnectted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetEmployees_Click(object sender, EventArgs e)
        {
            //change the connection as per ur requirement
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Johannes Chauke\Documents\EmpNewDB.mdf ""; ; Integrated Security = True; Connect Timeout = 30";

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from EmpTable";
                cmd.Connection = con;
                con.Open();
                DataTable Dt = new DataTable();
                Dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = Dt;
                con.Close();

            }
        }

        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            int EmpID = int.Parse(txtEmpID.Text);
            string EmpName = txtEmpName.Text;
            string EmpCity = txtEmpCity.Text;
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Johannes Chauke\Documents\EmpNewDB.mdf ""; ; Integrated Security = True; Connect Timeout = 30";

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into EmpTable Values(" + EmpID + ",'" + EmpName + "','" + EmpCity + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnDeleteEmployees_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.SelectedCells[0].RowIndex;
            int EmpID = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());

            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Johannes Chauke\Documents\EmpNewDB.mdf ""; ; Integrated Security = True; Connect Timeout = 30";

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete EmpTable Where EmpID=" + EmpID;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //Delete EmpTable Where EmpID=2
            }














                //int ID = dataGridView1.SelectedCells[0].RowIndex;
                //int EmpID =int.Parse(dataGridView1.Rows[ID].Cells[0].Value.ToString());
                //string EmpName = dataGridView1.Rows[ID].Cells[1].Value.ToString();
                //string EmpCity = dataGridView1.Rows[ID].Cells[2].Value.ToString();
                //string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Johannes Chauke\Documents\EmpNewDB.mdf ""; ; Integrated Security = True; Connect Timeout = 30";

                //using (SqlConnection con = new SqlConnection(constr))
                //{
                //    SqlCommand cmd = new SqlCommand();
                //    cmd.CommandText = "Delete EmpTable Where EmpID="+ EmpID;
                //    cmd.Connection = con;
                //    con.Open();
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //}

            }

        private void btnUpdateEmployees_Click(object sender, EventArgs e)
        {

            int id = dataGridView1.SelectedCells[0].RowIndex;
            int EmpID = int.Parse(dataGridView1.Rows[id].Cells[0].Value.ToString());
            string EmpName = dataGridView1.Rows[id].Cells[1].Value.ToString();
            string EmpCity = dataGridView1.Rows[id].Cells[2].Value.ToString();

            //update empTable set EmpName='jjj',EmpCity='hyd' where EmpID=5
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Johannes Chauke\Documents\EmpNewDB.mdf ""; ; Integrated Security = True; Connect Timeout = 30";

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Update EmpTable Set EmpName='" + EmpName + "',EmpCity='" + EmpCity + "'Where EmpID=" + EmpID;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //Delete EmpTable Where EmpID=2
            }


        }
    }
}
