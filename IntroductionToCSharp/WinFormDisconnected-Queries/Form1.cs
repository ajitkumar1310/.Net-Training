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

namespace WinFormDisconnected_Queries
{
    public partial class Form1 : Form
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\j1011718.JDA\Documents\EmpDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetEmployees_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            da = new SqlDataAdapter("Select * from EmpTable", con);
            //SqlCommand cmd = new SqlCommand("Select * from EmpTable",con);
            //cmd.Connection = con;
            //cmd.CommandText = "Select * from EmpTable";
            ds = new DataSet();
            da.Fill(ds, "EmpTable");
            cb = new SqlCommandBuilder(da);
            dataGridView1.DataSource = ds.Tables["EmpTable"];
        }

           
           
            
            
            
            
            
            
            
            
            ////using (SqlConnection con = new SqlConnection(constr))
            ////{
            //SqlConnection con = new SqlConnection(constr);
            //    da = new SqlDataAdapter("Select * from EmpTable",con);
            //    cb = new SqlCommandBuilder(da);
            //    da.UpdateCommand=cb.GetUpdateCommand();
            //    da.InsertCommand = cb.GetInsertCommand();
            //    ds = new DataSet();
            //    da.Fill(ds,"EmpTable");
                
            //    dataGridView1.DataSource = ds.Tables["EmpTable"];
            //    con.Close();
                
                
            
        

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            ds.Tables["EmpTable"].Rows[rowindex][0] = dataGridView1.Rows[rowindex].Cells[0].Value;
            ds.Tables["EmpTable"].Rows[rowindex][1] = dataGridView1.Rows[rowindex].Cells[1].Value;
            ds.Tables["EmpTable"].Rows[rowindex][2] = dataGridView1.Rows[rowindex].Cells[2].Value;











            //int rowindex = dataGridView1.CurrentCell.RowIndex;

            //ds.Tables["EmpTable"].Rows[rowindex][0] = dataGridView1.Rows[rowindex].Cells[0].Value;
            //ds.Tables["EmpTable"].Rows[rowindex][1] = dataGridView1.Rows[rowindex].Cells[1].Value;
            //ds.Tables["EmpTable"].Rows[rowindex][2] = dataGridView1.Rows[rowindex].Cells[2].Value;



        }

        private void btnInsertEmp_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["EmpTable"].NewRow();
            dr["EmpID"] = textBox1.Text;
            dr["EmpName"] = txtEmpName.Text;
            dr["EmpCity"] = textBox3.Text;
            ds.Tables["EmpTable"].Rows.Add(dr);













            //DataRow dr = ds.Tables["EmpTable"].NewRow();
            //dr["EmpID"] = textBox1.Text;
            //dr["EmpName"] = txtEmpName.Text;
            //dr["EmpCity"] = textBox3.Text;
            //ds.Tables["EmpTable"].Rows.Add(dr);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
           // int EmpID = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            ds.Tables["EmpTable"].Rows[rowindex].Delete();

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
        using (SqlConnection con = new SqlConnection(constr))
        {
            da.InsertCommand = cb.GetInsertCommand();
            da.InsertCommand.Connection = con;
            da.UpdateCommand = cb.GetUpdateCommand();
            da.UpdateCommand.Connection = con;
            da.DeleteCommand = cb.GetDeleteCommand();
            da.DeleteCommand.Connection = con;

            da.Update(ds, "EmpTable");


        }
        }
    }
}
