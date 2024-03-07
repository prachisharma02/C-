using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionStateDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null && Session["pass"]!=null) // agar hm yaha or|| condition denege to else part nhi chlega kyuiki maanlo hmne null values daali to inme se ek condition to true hogyi ek false bhale he to execute hoga he
            {
                Response.Write("This email and password is stored to the session.and they are ");                  
                Response.Write(Session["email"]);
                Response.Write(Session["pass"]);
                // Label2.Text = Session["email"].ToString();
                //Label3.Text = Session["pass"].ToString();

            }
            else
            {
                Response.Redirect("WebForm1.aspx");
            }
        }
    }
}