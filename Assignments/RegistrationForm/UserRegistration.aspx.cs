using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RegistrationForm
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void btnButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=PRSQL;Initial Catalog=User Registration;User ID=labuser;Password=Welcome123$");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[UserRegistration]
           ([UserName]
           ,[age]
           ,[emailID]
           ,[passwrd]
           ,[cnfpwd])
     VALUES
           ('" + txtUserName.Text + "', '" + txtAge.Text + "' ,'" + txtEmailID + "' ,'" + txtPassword + "' ,'" + txtCNFPWD.Text+"')",conn) ;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("<script>alert('user is Registrated successfully')</script>");

        }
    }
}