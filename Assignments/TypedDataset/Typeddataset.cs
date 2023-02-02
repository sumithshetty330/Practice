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


namespace TypedDataset
{
    public partial class Typeddataset : Form
    {
        DataSet ds;
        SqlConnection objConn;
        SqlCommand objCmd;
        SqlDataAdapter da;
        string strcmd;
        public Typeddataset()
        {
            InitializeComponent();
            string strConn = @"Data Source=PRSQL;Initial Catalog=Test;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            objConn = new SqlConnection(strConn);
            string strCmdSelect = @"Select * from Employee";
            objCmd = new SqlCommand(strCmdSelect, objConn);

            da = new SqlDataAdapter();
            da.SelectCommand = objCmd;
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
        }
        private void Typed_Click(object sender, EventArgs e)
        {
            DataSet1 eTds = new DataSet1();
            da.Fill(eTds, "Employee");
            Typed.Text = eTds.Employee[1].Name;

        }

        private void UnTyped_Click(object sender, EventArgs e)
        {
            ds.Clear();
            da.Fill(ds, "Employee");
            Typed.Text = (string)ds.Tables["Employee"].Rows[0]["EmpName"];
            dgvEmployee.DataSource = ds;
            dgvEmployee.DataMember = "Employee";

        }

        private void UpdateUntyped_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Employee"];
            DataRow row = dt.Rows[2];
            row["EmpName"] = "Sumith";
            da.Update(ds.Tables["Employee"]);
            MessageBox.Show((string)ds.Tables["Employee"].Rows[2]["EmpName"]);

        }
    }
}


