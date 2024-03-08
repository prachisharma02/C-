using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HiddenStateDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GenerateCount(object sender, EventArgs e)
        {
            //here everytime it will become 0 and increase by 1
            count =int.Parse(hidden.Value); // count me hidden value (string 0) int me convert kiya
            count += 1; // increase hua
            Response.Write("Count increased after Button click : "+" "+count);// display hua 
            // fir agar hm dubara button pe click krenge to vo dubara se 0 hojaygi after page reload
            // but hm kya krenge ki hiddenvalue me vo store kra lenge aur
            hidden.Value=count.ToString(); // now after adding this only value gets converted tostring
           // then again this process ab ye increased value k sath sara process hoga 
        }
        protected void Generatedetails(object sender, EventArgs e)
        {
            string username = first.Text;
            string password = second.Text;

            Hidden2.Value = username;
            Hidden3.Value = password;

            // Use the values as needed for non-sensitive purposes
            Response.Write("The person is " + username + " " + password);
        }


    }
}