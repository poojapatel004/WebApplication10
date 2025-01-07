using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class rotetor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename = FileUpload1.FileName;
            String path=Server.MapPath("~/FILES/") + filename;
            FileUpload1.SaveAs(path);
            Label1.Text = "File Uploaded";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text =Calendar1.SelectedDate.ToString();
            //Label1.Text= Calendar1.SelectMonthText.ToString();
        }
    }
}