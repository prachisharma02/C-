using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookiesdemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("user");  // non-persistent cookies
            cookie["username"] = first.Text;
            cookie["password"] = second.Text;
            cookie.Expires = DateTime.Now.AddDays(2);// after adding these it becomes persistent cookie
            Response.Cookies.Add(cookie); //ye line hmare browser me hmari cookie ko store krva rhi hai or store krva rhi hai 
            Response.Redirect("WebForm2.aspx");
        }
    }
}