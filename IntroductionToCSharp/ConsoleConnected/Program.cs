using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleConnected
{
    class Program
    {
        static void Main(string[] args)
        {

            //connection-connecting to db(db name,username,password)

            //command object-query string ,con

            //open the connection

            //execute our commands

            //display data 

            //close the connection

            //using-try and finally


            //SqlConnection con = new SqlConnection(constr);
            //try
            //{

            //}
            //finally
            //{
            //    con.Dispose();
            //}
            //use try finally or use below code
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Johannes Chauke\Documents\EmpNewDB.mdf ""; ; Integrated Security = True; Connect Timeout = 30";
            
            using (SqlConnection con =new  SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from EmpTable";
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr= cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "   " + dr["EmpName"]+"     "+dr[2]);
                }
                con.Close();

            }


            Console.WriteLine("---------------Updating the Table------------");

            using (SqlConnection con = new SqlConnection(constr))
            {

                //updated the table by opening and closing connection
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Update EmpTable Set EmpName='AbhinavKumarAvinash' where EmpID=2 ";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //read the table by opening and closing connection

                cmd.CommandText = "Select * from EmpTable";
                con.Open();
                
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                dr.Read();

                Console.WriteLine(dr[0] + "   " + dr["EmpName"] + "     " + dr[2]);
                con.Close();

            }

            Console.WriteLine("---------------Deleting the Table------------");

            using (SqlConnection con = new SqlConnection(constr))
            {

                //updated the table by opening and closing connection
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete EmpTable where EmpID=2 ";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //read the table by opening and closing connection

                cmd.CommandText = "Select * from EmpTable";
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "   " + dr["EmpName"] + "     " + dr[2]);
                }
                con.Close();

            }


            //Console.WriteLine("---------------Inserting into the Table------------");

            //using (SqlConnection con = new SqlConnection(constr))
            //{

            //    //updated the table by opening and closing connection
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "Insert into EmpTable Values(5,'AAAAAA','vizag') ";
            //    cmd.Connection = con;
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();

            //    //read the table by opening and closing connection

            //    cmd.CommandText = "Select * from EmpTable";
            //    con.Open();

            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        Console.WriteLine(dr[0] + "   " + dr["EmpName"] + "     " + dr[2]);
            //    }
            //    con.Close();

            //}












            // string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\j1011718.JDA\Documents\EmpDB.mdf; Integrated Security = True; Connect Timeout = 30";


            //    using (SqlConnection con = new SqlConnection(constr))
            //{
            //    //     SqlCommand cmd = new SqlCommand();
            //     cmd.CommandText = "Select * from EmpTable";
            //     cmd.Connection = con;
            //     con.Open();
            //     SqlDataReader dr = cmd.ExecuteReader();
            //     while(dr.Read())
            //     {
            //         Console.WriteLine(dr["EmpID"] + "    " + dr["EmpName"] + "      " + dr["EmpCity"]);
            //     }
            //     con.Close();
            // }

            // Console.WriteLine("Updating the Table");
            //// string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\j1011718.JDA\Documents\EmpDB.mdf; Integrated Security = True; Connect Timeout = 30";
            // using (SqlConnection con = new SqlConnection(constr))
            // {
            //     SqlCommand cmd = new SqlCommand();
            //     cmd.CommandText = @"Update EmpTable set EmpName='AbhinavKumar' where EmpID=2";
            //     cmd.Connection = con;
            //     con.Open();
            //     cmd.ExecuteNonQuery();
            //     con.Close();

            //     cmd.CommandText = "Select * from EmpTable";
            //     cmd.Connection = con;
            //     con.Open();
            //     SqlDataReader dr = cmd.ExecuteReader();
            //     while (dr.Read())
            //     {
            //         Console.WriteLine(dr["EmpID"] + "    " + dr["EmpName"] + "      " + dr["EmpCity"]);
            //     }
            //     con.Close();


            // }


        }
    }
}
