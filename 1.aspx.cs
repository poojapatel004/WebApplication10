using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class _1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Helloo World");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox1.Text, out int num1) &&
                int.TryParse(TextBox2.Text, out int num2) &&
                int.TryParse(TextBox3.Text, out int num3))
            {
                
                int sum = num1 + num2 + num3;

                
                lblResult.Text = "The sum is: " + sum.ToString();
            }
            else
            {
                
                lblResult.Text = "Please enter valid numbers.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}