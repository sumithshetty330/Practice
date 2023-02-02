using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using LinqDataset;
using LinqDataset.LinqDataSet1TableAdapters;

namespace LinqToDataset
{
    class Program
    {
        static void UnTypedDataset()
        {
            string strconn = @"Data Source=PRSQL;Initial Catalog=test;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString = strconn;



            SqlCommand objCmd = new SqlCommand();
            string strCmd = @"Select * from Employee";
            objCmd.Connection = objConn;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = strCmd;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = objCmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee");
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(da);
            DataTable empTable = ds.Tables["Employee"];



            var query = from emp in empTable.AsEnumerable()
                        select new
                        {
                            ID = emp.Field<Int16>("ID"),
                            Name = emp.Field<String>("Name"),
                            Salary = emp.Field<Decimal>("Salary"),
                            DID = emp.Field<Byte>("DID")

                        };



            Console.Write("ID\t");
            Console.Write("Name\t");
            Console.Write("\tSalary\t");
            Console.Write("\tDID");
            Console.WriteLine("----------------------------------------------");



            foreach (var e in query)
            {
                Console.Write("{0}\t", e.ID);
                Console.Write("{0}\t", e.Name);
                Console.Write("{0}\t", e.Salary);
                Console.Write("{0}\t", e.DID);



            }



        }
        static void TypedDataSet()
        {
            LinqDataSet1 ds = new LinqDataSet1();
           



            var query = from emp in ds.Employee
                        select new
                        {
                            ID = emp.ID,
                            Name = emp.Name,
                            Salary = emp.Salary,
                            DID = emp.DID
                        };
            //LinqDataSet1.EmployeeRow row = ds.Employee.NewEmployeeRow();
            //row.Name = "rock";
            //row.Salary = 18339;
            //row.DID = 1;
            //ds.Employee.Rows.Add(row);
            //EmployeeTableAdapter.Update(ds.Employee);



            Console.WriteLine("ID\t");
            Console.WriteLine("Name\t");
            Console.WriteLine("\tSalary\t");
            Console.WriteLine("\tDID");
            Console.WriteLine("_____________________________________________________");
            foreach (var e in query)
            {
                Console.WriteLine("{0}\t", e.ID);
                Console.WriteLine("{0}\t", e.Name);
                Console.WriteLine("{0}\t", e.Salary);
                Console.WriteLine("{0}\t", e.DID);
            }
        }

        static void TwoTableQuery()
        {
            SqlConnection connobject = new SqlConnection();
            SqlCommand cmdobject = new SqlCommand();
            string strconn = @"Data Source=PRSQL;Initial Catalog=Employee;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            string strcmd = "Select EmployeeID,EmployeeName,EmployeeSalary,DepartmentID From EmployeeTable";
            connobject.ConnectionString = strconn;
            cmdobject.Connection = connobject;
            cmdobject.CommandType = CommandType.Text;
            cmdobject.CommandText = strcmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmdobject;
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "Employee");
            DataTable emptable = ds.Tables["Employee"];
            strcmd = "Select DepartmentID,DepartmentName From DepartmentTable ";
            cmdobject.CommandText = strcmd;
            adapter.Fill(ds, "Department");
            DataTable Departmenttable = ds.Tables["Department"];
            var query = from emp in emptable.AsEnumerable()
                        join Department in Departmenttable.AsEnumerable()
                        on emp.Field<Byte>("DepartmentID") equals Department.Field<int>("DepartmentID")
                        select new
                        {
                            ID = emp.Field<int>("EmployeeID"),
                            Name = emp.Field<String>("EmployeeName"),
                            Salary = emp.Field<decimal>("EmployeeSalary"),
                            DID = emp.Field<int>("DepartmentID")
                        };
            Console.Write("ID\t");
            Console.Write("Name\t");
            Console.Write("\tSalary\t");
            Console.Write("\tDID\t");
            Console.WriteLine("--------------------------------");
            foreach (var e in query)
            {
                Console.Write("{0}\t", e.ID);
                Console.Write("{0}\t", e.Name);
                Console.Write("{0}\t", e.Salary);
                Console.Write("{0}\t", e.DID);
            }


        }











        static void Main(string[] args)
        {
            TypedDataSet();
            UnTypedDataset();
            TwoTableQuery();
        }
    }
}