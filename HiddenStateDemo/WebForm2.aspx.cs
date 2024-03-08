using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HiddenStateDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = Request.Form["hidden"];
            string b = Request.Form["Hidden2"];
            string c = Request.Form["Hidden3"];
            Response.Write("Count increased after Button click : " + " " + a);
            Response.Write("The person is " + b + " " + c);

        }
    }
}