using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDOperation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) 
        {
            string name =TextBox2.Text;
            int phoneno = int.Parse(TextBox1.Text);
            string email=TextBox3.Text;
            string passw =TextBox4.Text;


        }

    }
}