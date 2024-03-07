using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionStateDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Click(object sender, EventArgs e)
        {
            
                // Storing email to Session variable  
              //  Session.Add("email", email.Text); another way to store data
                Session["email"] = email.Text;
                Session["pass"] = password.Text;
                Response.Redirect("WebForm2.aspx");


            
            // Checking Session variable is not empty  
            //if (Session["email"] != null)
            //{
            //    // Displaying stored email  
            //    Label3.Text = "This email is stored to the session.";
            //    Label4.Text = Session["email"].ToString();
            //}
        }
    }
}