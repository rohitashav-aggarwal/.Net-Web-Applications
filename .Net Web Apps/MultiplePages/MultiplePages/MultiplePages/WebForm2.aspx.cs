using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiplePages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // find previous page and get name from its text box txtName
            Page previous = Page.PreviousPage;
            if (previous != null)
            {
                TextBox tb = (TextBox)previous.FindControl("txtName");
                lblName.Text = tb.Text;
            }
            else
                lblName.Text = "unknown";
        }

        // go back to the first form
        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            //Server.Transfer("~/WebForm1.aspx");
        }
    }
}