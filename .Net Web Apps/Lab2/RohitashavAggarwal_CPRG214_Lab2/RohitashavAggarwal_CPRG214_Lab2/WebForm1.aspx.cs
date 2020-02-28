using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RohitashavAggarwal_CPRG214_Lab2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DateTime result;
            string date = e.NewValues[0].ToString(); // grab the value typed in the field as a string
            if (!DateTime.TryParse(date, out result)) // test is the format matches the datetime
            {
                e.NewValues[0] = null; // if format do not match then add null
            }
        }
    }
}