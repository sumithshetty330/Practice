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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        String strConn= @"Data Source=PRSQL;Initial Catalog=Test;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
        SqlConnection sqConn;
        String strSelect = @"Select * From Employee";
        String strInsert;
        SqlCommand selectComaand;
        SqlCommand insertComaand;
        SqlDataReader dr;
        bool flag = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (sqConn.State == ConnectionState.Closed)
                {
                    sqConn.Open();
                    dr = selectComaand.ExecuteReader();
                }
                if (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtSalary.Text = dr["Salary"].ToString();
                    txtDept.Text = dr["DID"].ToString();
                }
            }
        }

        private void te_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
