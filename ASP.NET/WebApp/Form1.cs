using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApp
{
    public class Form1
    {
        String strConn = @"Data Source=PRSQL;Initial Catalog=Test;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
        SqlConnection objconn = new SqlConnection();
        
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        SqlDataAdapter da = new SqlDataAdapter();
        string strcmd = @"Select * From Department";

     
      

        
       
    }
}