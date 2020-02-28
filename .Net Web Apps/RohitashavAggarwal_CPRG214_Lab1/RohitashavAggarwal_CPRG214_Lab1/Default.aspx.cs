using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RohitashavAggarwal_CPRG214_Lab1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page load empty
        }

        // Once convert button is clicked 9 different conversions happen, all of them rounded to 2 decimal places
        protected void btnConvert_Click(object sender, EventArgs e)
        {
            if(DropDownListFrom.SelectedValue == "Celsius" && DropDownListTo.SelectedValue == "Farenheit")
            {
                double input = Convert.ToDouble(txtInput.Text);
                double output = (input * (9 / 5)) + 32;
                txtOutput.Text = Convert.ToString(Math.Round(output, 2));
            }

            else if(DropDownListFrom.SelectedValue == "Celsius" && DropDownListTo.SelectedValue == "Kelvin")
            {
                double input = Convert.ToDouble(txtInput.Text);
                double output = input + 273.15;
                txtOutput.Text = Convert.ToString(Math.Round(output, 2));
            }

            else if (DropDownListFrom.SelectedValue == "Celsius" && DropDownListTo.SelectedValue == "Celsius")
            {
                double input = Convert.ToDouble(txtInput.Text);
                txtOutput.Text = Convert.ToString(Math.Round(input, 2));
            }

            else if (DropDownListFrom.SelectedValue == "Farenheit" && DropDownListTo.SelectedValue == "Celsius")
            {
                double input = Convert.ToDouble(txtInput.Text);
                double output = (input - 32) * (5/9);
                txtOutput.Text = Convert.ToString(Math.Round(output, 2));
            }

            else if (DropDownListFrom.SelectedValue == "Farenheit" && DropDownListTo.SelectedValue == "Kelvin")
            {
                double input = Convert.ToDouble(txtInput.Text);
                double output = ((input - 32) * (5 / 9) + 273.15);
                txtOutput.Text = Convert.ToString(Math.Round(output, 2));
            }

            else if (DropDownListFrom.SelectedValue == "Farenheit" && DropDownListTo.SelectedValue == "Farenheit")
            {
                double input = Convert.ToDouble(txtInput.Text);
                txtOutput.Text = Convert.ToString(Math.Round(input, 2));
            }

            else if (DropDownListFrom.SelectedValue == "Kelvin" && DropDownListTo.SelectedValue == "Celsius")
            {
                double input = Convert.ToDouble(txtInput.Text);
                double output = (input - 273.15);
                txtOutput.Text = Convert.ToString(Math.Round(output, 2));
            }

            else if (DropDownListFrom.SelectedValue == "Kelvin" && DropDownListTo.SelectedValue == "Farenheit")
            {
                double input = Convert.ToDouble(txtInput.Text);
                double output = (input - 273.15) * (9 / 5) + 32;
                txtOutput.Text = Convert.ToString(Math.Round(output, 2));
            }

            else
            {
                double input = Convert.ToDouble(txtInput.Text);
                txtOutput.Text = Convert.ToString(Math.Round(input, 2));
            }
        }

        // clear button clears the text/label fields and resets the controls back to celsius to farenheit
        protected void btnClear_Click(object sender, EventArgs e)
        {
                txtInput.Text = "" ;
                txtOutput.Text = "" ;
                DropDownListFrom.SelectedValue = "Celsius";
                DropDownListTo.SelectedValue = "Farenheit";
        }
    }
}