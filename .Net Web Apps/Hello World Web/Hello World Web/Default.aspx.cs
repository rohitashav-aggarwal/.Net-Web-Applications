using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello_World_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGreet_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello " + txtName.Text + "!";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello World!";
            txtName.Text = "";
            txtName.Focus();
        }

        // display random image
        protected void btnChange_Click(object sender, EventArgs e)
        {
            const int NR_IMAGES = 5;
            Random rnd = new Random();
            int nr = rnd.Next(NR_IMAGES);
            switch (nr) 
            {
                case 0: 
                    Image1.ImageUrl = @"~\Images\lake.jpg";
                    break;
                case 1:
                    Image1.ImageUrl = @"~\Images\mountains.jpeg";
                    break;
                case 2:
                    Image1.ImageUrl = @"~\Images\sunset.jpg";
                    break;
                case 3:
                    Image1.ImageUrl = @"~\Images\tree.jfif";
                    break;
                case 4:
                    Image1.ImageUrl = @"~\Images\windmill.jpg";
                    break;
            }
        }
    }
}