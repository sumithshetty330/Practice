using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class DataHandle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            GridView1.DataSource= dbContext.Departments;
            GridView1.DataBind();

          
        }
    }
}