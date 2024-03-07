using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookiesdemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // non-persistent cookies
            HttpCookie cookie = Request.Cookies["user"]; // httpcookie is a class 
            if (cookie != null)
            {
                Response.Write("Welcome  " +"  "+ cookie["username"].ToString()+" "+" password is "+ cookie["password"].ToString());
            }
            else
                Response.Redirect("webForm1.aspx");

        }


      protected void DdlItems_SelectedIndexChanged(object sender, EventArgs e)
{
    switch (ddlItems.SelectedIndex)
    {
        case 0:
            first_Selected(sender, e);
            break;
        case 1:
            second_Selected(sender, e);
            break;
        case 2:
            third_Selected(sender, e);
            break;
    }
}
        protected void first_Selected(object sender, EventArgs e)
        {
            Response.Write("first selected");
        }

        protected void second_Selected(object sender, EventArgs e)
        {
            Response.Write("Second selected");
        }

        protected void third_Selected(object sender, EventArgs e)
        {
            Response.Write("third selected");
        }


    }
}