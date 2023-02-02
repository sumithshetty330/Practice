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

namespace EmployeeDB
{
    public partial class Form1 : Form
    {
        SqlConnection objConn;
        SqlCommand objCmd;
        IDataReader dr;
        String strCmd;
        string strConn = @"Data Source = PRSQL; Initial Catalog = test; Persist Security Info=True;User ID = labuser; Password=Welcome123$";
        public Form1()
        {
            InitializeComponent();
            objConn = new SqlConnection(strConn);
            objCmd = new SqlCommand();
            objCmd.Connection = objConn;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            strCmd = @"UPDATE Employee SET Salary='" + textSalary.Text + "' WHERE ID='" + txtID.Text + "' ";

            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + "Record Updated");


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            strCmd = @"Select * From Employee";
            objCmd.CommandText=strCmd;

            objConn.Open();
            dr=objCmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            objConn.Close();
            dgvEmployee.DataSource = dt;

        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            strCmd = @"Insert Into Employee Values('" + textName.Text + "','" + textSalary.Text + "','" + textDept.Text + "')";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + " Records Inserted");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            strCmd = @"Insert Into Employee Values('" + textName.Text + "','" + textSalary.Text + "','" + textDept.Text + "')";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + " Records Inserted");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            strCmd = @"Select * From Employee";
            objCmd.CommandText = strCmd;

            objConn.Open();
            dr = objCmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            objConn.Close();
            dgvEmployee.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            strCmd = @"Delete From Employee Where Salary>" + textSalary.Text + " ";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + "Records Deleted");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            strCmd = @"UPDATE Employee SET EmployeeSalary='" + textSalary.Text + "' WHERE EmployeeID='" + txtID.Text + "' ";

            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + "Record Updated");
        }
    }
}
