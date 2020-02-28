using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StatePractice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string session;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {
                session = Session["Name"].ToString();
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Add(Session["Name"].ToString());
        }
    }
}