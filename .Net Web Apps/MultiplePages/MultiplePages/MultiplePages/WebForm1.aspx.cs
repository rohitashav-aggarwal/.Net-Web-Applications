using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiplePages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // transfer to second page
        protected void btnGo_Click(object sender, EventArgs e)
        {
            //Server.Transfer("~/WebForm2.aspx");
        }

        // transfer to an arbitrary external page
        protected void btnSAIT_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.sait.ca/");
        }
    }
}