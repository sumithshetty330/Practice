using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection objConn;
        SqlCommand objCmd;
        SqlDataAdapter da;
        string strCmd;
        String strconn = @"Data Source = PRSQL; Initial Catalog = Test; Persist Security Info=True;User ID = labuser; Password=Welcome123$";
        SqlCommandBuilder cmdBuilder;   
        DataTable dt=new DataTable();
        public Form1()
        {
            InitializeComponent();
            objConn= new SqlConnection(strconn);
            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            String strCmd = @"Select * From Employee";

            da=new SqlDataAdapter();
            da.SelectCommand = objCmd;
            objCmd.CommandText = strCmd;
            cmdBuilder = new SqlCommandBuilder(da);
           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dt.Clear();
            da.Fill(dt);
            dgvEmployee.DataSource = dt;

        }
        private void btnUpdate_Click(object sender,EventArgs e)
        {
            da.Update(dt);
        }
    }
}
