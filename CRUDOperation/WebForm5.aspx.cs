using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDOperation
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-ERN1FTED;Initial Catalog=Student;Integrated Security=True;Encrypt=False");
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            int phoneno = int.Parse(TextBox2.Text);
            string email = TextBox3.Text;
            string passw = TextBox4.Text;
            string query1 = "insert into details values(@name,@phoneno,@email,@passw)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query1, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phoneno", phoneno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@passw", passw);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string query = "delete from details where name=@name";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);

            cmd.ExecuteNonQuery();
            conn.Close();

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Request.Form["tb5"];
            TextBox1.Text = Request.Form["tb1"];
            TextBox1.Text = Request.Form["tb2"];
            TextBox1.Text = Request.Form["tb3"];
            TextBox1.Text = Request.Form["tb4"];

            try
            {
                string name = TextBox1.Text;
                int phoneno = int.Parse(TextBox2.Text);
                string email = TextBox3.Text;
                string passw = TextBox4.Text;
                string query = "update biography set name=@name,phoneno=@phoneno,email=@email,password=@passw where name=@name";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phoneno", phoneno);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@passw", passw);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

        }
        //protected void Button4_Click(object sender, EventArgs e)
        //{
        //    string query = "select * from details";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable data = new DataTable();
        //    adapter.Fill(data);
        //    grid.DataSource = data;
        //    grid.DataBind();
        //}
    }
}