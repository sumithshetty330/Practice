using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class GreetingForm : System.Web.UI.Page
    {

        public void Page_PreInit(object sender, EventArgs e, object lblName)
        {
            Response.Write("PreInit</br>");
        }
            protected void Page_Init(object sender, EventArgs e)
            {
            Response.Write("Init</br>");
        }
            protected void Page_InitComplete(object sender, EventArgs e)
            {
            Response.Write("InitComplete</br>");

        }
            protected override void OnPreLoad(EventArgs e)
            {
            Response.Write("OnPreLoad</br>");

        }
            protected void Page_Load(object sender, EventArgs e)
            {
            Response.Write("Load</br>");

            }
            protected void btnSubmit_Click(object sender, EventArgs e)
            {
            

            }
            protected void Page_LoadComplete(object sender, EventArgs e)
            {
            Response.Write("LoadComplete</br>");
             }
            protected override void OnPreRender(EventArgs e)
            {
            Response.Write("OnPreRender</br>");
        }
            protected override void OnSaveStateComplete(EventArgs e)
            {
            Response.Write("OnSaveStateComplete</br>");
        }
            protected void Page_Unload(object sender, EventArgs e)
            {
            

        }
        }
    }