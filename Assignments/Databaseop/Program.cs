using System;
using System.Data;
using System.Data.SqlClient;

namespace Databaseop
{
    class Program
    {
        static void connected()
        {
            String strConn = "Data Source=PRSQL;Initial Catalog=test;User ID=labuser;Password=Welcome123$";
            SqlConnection objconn = new SqlConnection();
            objconn.ConnectionString = strConn;

            SqlCommand objcmd=new SqlCommand();
            string strcmd = @"select * From Employee";
            objcmd.Connection=objconn;
            objcmd.CommandType = CommandType.Text;
            objcmd.CommandText=strcmd;

            SqlDataReader reader;
            objconn.Open();
            reader=objcmd.ExecuteReader();//Return data reader object which will refer the result set for read Operation
            Console.WriteLine("ID");
            Console.WriteLine("\tName");
            Console.WriteLine("\t Salary");
            Console.WriteLine("\tDepID");
            Console.WriteLine("-------------------------");
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                Console.WriteLine("\t" + reader[1]);
                Console.WriteLine(reader[2]);
                Console.WriteLine("\t" + reader[3]);
            }
            reader.Close(); 
            objconn.Close();    
        }
        static void Disconnected()
        {

            String strConn = @"Data Source=PRSQL;Initial Catalog=Employee;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            SqlConnection conn = new SqlConnection(strConn);
            conn.ConnectionString = strConn;

            SqlCommand objcmd = new SqlCommand();
            string strcmd = @"select * From Employee";
            objcmd.Connection = conn;
            objcmd.CommandType = CommandType.Text;
            objcmd.CommandText = strcmd;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = objcmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "MyEmployee");//Fill() method-Opens Connection, Runs Command, Stores result set locally in dataset object.
            DataTable empTable = ds.Tables["MyEmployee"];




            Console.WriteLine("ID");
            Console.WriteLine("\tName");
            Console.WriteLine("\t Salary");
            Console.WriteLine("\tDepID");
            Console.WriteLine("-------------------------");
            foreach (DataRow row in empTable.Rows)
            {
                Console.WriteLine(row[0]);
                Console.WriteLine("\t" + row[1]);
                Console.WriteLine(row[2]);
                Console.WriteLine("\t" + row[3]);
            }
            Console.WriteLine("****************************");
        
        }
        static void ConnectedAutoFill()
        {
            String strConn = @"Data Source=PRSQL;Initial Catalog=Employee;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            SqlConnection objconn = new SqlConnection(strConn);
            objconn.ConnectionString = strConn;

            SqlCommand objcmd = new SqlCommand();
            string strcmd = @"select * From Employee";
            objcmd.Connection = objconn;
            objcmd.CommandType = CommandType.Text;
            objcmd.CommandText = strcmd;

            SqlDataReader reader;
            DataTable dt = new DataTable();
            objconn.Open();
            reader= objcmd.ExecuteReader();
            dt.Load(reader);
            reader.Close(); 
            objconn.Close();
            Console.WriteLine("ID");
            Console.WriteLine("\tName");
            Console.WriteLine("\t Salary");
            Console.WriteLine("\tDepID");
            Console.WriteLine("-------------------------");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row[0]);
                Console.WriteLine("\t" + row[1]);
                Console.WriteLine(row[2]);
                Console.WriteLine("\t" + row[3]);
            }
            Console.WriteLine("****************************");





        }


        static void Main()
        {
           // Disconnected(); 
            connected(); 
            ConnectedAutoFill();
  

        }
    }
}
