using System;


namespace StateManage
{
    public partial class ViewState : System.Web.UI.Page
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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("Hello Martin Odegaard");
        }
    }
}