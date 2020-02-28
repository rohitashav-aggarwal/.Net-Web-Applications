using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayrollWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // turn off unobtrusive validation
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        // calculate pay amount based on hours and rate
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            const decimal FULL_WEEK = 37.5m;
            const decimal OT_RATE = 1.5m;

            decimal hours; // hours worked
            decimal rate; // hourly rate
            decimal payAmount; // to calculate: pay amount

            // get inputs
            hours = Convert.ToDecimal(txtHours.Text);
            rate = Convert.ToDecimal(txtRate.Text);

            // calculate pay
            if (hours <= FULL_WEEK) // all straight time
                payAmount = hours * rate;
            else // there is overtime
                payAmount = FULL_WEEK * rate +
                           (hours - FULL_WEEK) * rate * OT_RATE;

            // display pay
            lblPay.Text = payAmount.ToString("c");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
            txtRate.Text = "";
            lblPay.Text = "";
            txtHours.Focus();
        }
    }
}