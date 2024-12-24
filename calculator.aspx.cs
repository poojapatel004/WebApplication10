using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class calculator : System.Web.UI.Page
    {
        int num1;

        string op = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void zero_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "0";
            }
            else
            {
                tx.Text = tx.Text + "0";
            }
        }

        protected void one_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "1";
            }
            else
            {
                tx.Text = tx.Text + "1";
            }
        }

        protected void two_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "2";
            }
            else
            {
                tx.Text = tx.Text + "2";
            }
        }

        protected void three_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "3";
            }
            else
            {
                tx.Text = tx.Text + "3";
            }
        }

        protected void four_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "4";
            }
            else
            {
                tx.Text = tx.Text + "4";
            }
        }

        protected void five_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "5";
            }
            else
            {
                tx.Text = tx.Text + "5";
            }

        }

        protected void six_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "6";
            }
            else
            {
                tx.Text = tx.Text + "6";
            }
        }

        protected void seven_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "7";
            }
            else
            {
                tx.Text = tx.Text + "7";
            }
        }

        protected void eight_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "8";
            }
            else
            {
                tx.Text = tx.Text + "8";
            }
        }

        protected void nine_Click(object sender, EventArgs e)
        {
            if (tx.Text == "0" && tx.Text != null)
            {
                tx.Text = "9";
            }
            else
            {
                tx.Text = tx.Text + "9";
            }
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            tx.Text = "";

        }

        protected void plus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(tx.Text);
            tx.Text = "0";
            op = "+";
        }

        protected void minus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(tx.Text);
            tx.Text = "0";
            op = "-";
        }

        protected void division_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(tx.Text);
            tx.Text = "0";
            op = "/";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(tx.Text);
            tx.Text = "0";
            op = "*";
        }

        protected void answer_Click(object sender, EventArgs e)
        {
            int num2;
            int result;
            num2 = Convert.ToInt32(tx.Text);
            if (op == "+")
            {
                result = num1 + num2;
                tx.Text = result.ToString(); num1 = result;
            }
            else if (op == "-")
            {
                result = num1 - num2; tx.Text = result.ToString();
                num1 = result;
            }
            else if (op == "*")
            {
                result = num1 * num2;
                tx.Text = result.ToString();
                num1 = result;
            }
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    tx.Text = "Cannot divide by zero";
                }
                else
                {
                    result = num1 / num2;
                    tx.Text = result.ToString();
                    num1 = result;
                }
            }
        }
    }
}