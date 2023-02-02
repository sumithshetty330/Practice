using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManage
{
    public partial class SiteMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                lstCourse.Items.Add("MCA");
                lstCourse.Items.Add("B.Tech");
                lstCourse.Items.Add("MBA");
            }
        }
    }
}