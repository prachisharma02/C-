using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionStateDemo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null || Session["pass"] != null)
            {
                Response.Write("This email and password is stored to the session.and they are ");
                Response.Write(Session["email"]);
                Response.Write(Session["pass"]);
               

            }
            else
            {
                Response.Redirect("WebForm1.aspx");
            }
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
        }
}