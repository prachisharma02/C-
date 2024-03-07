using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Write("postback done");
            }
        }
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            ViewState["password"] = TextBox2.Text;

            TextBox1.Text = TextBox2.Text = string.Empty; 
            // iska kaam hai sirf clear krna viewstate se delete krna nhi 
            // hmara server bna hai jab hm restore krenge values vapas aa jaygi
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (ViewState["name"] != null)
            {
                TextBox1.Text = ViewState["name"].ToString();
            }

            if (ViewState["password"] != null)
            {
                TextBox2.Text = ViewState["password"].ToString();
            }
        }
    }
}