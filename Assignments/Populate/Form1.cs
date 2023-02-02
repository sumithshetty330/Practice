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

namespace Populate
{
    public partial class Form1: Form
    {
  
        DataSet ds;
        SqlConnection objConn;
        SqlCommand objCmd;
        SqlDataAdapter da;
        string strcmd;
        string strconn = @"Data Source=PRSQL;Initial Catalog=MindtreeDB;User ID=labuser;Password=Welcome123$";
        public Form1()
        {
            InitializeComponent();
            objConn = new SqlConnection(strconn);
            string strCmdSelect = @"Select * from Employee";
            objCmd = new SqlCommand(strCmdSelect, objConn);

            da = new SqlDataAdapter();
            da.SelectCommand = objCmd;
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
        }


   

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
