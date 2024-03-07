using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("default2.aspx?firstname=" + TextBox1.Text + "&lastname=" + TextBox2.Text);

    }
}
