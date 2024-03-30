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
            if (!IsPostBack)
            {
                if (Request.QueryString["name"] != null)
                {
                    string name = Request.QueryString["name"];
                    // Fetch data associated with the specified name and populate the edit form
                    PopulateEditForm(name);
                }
            }
        }
        private void PopulateEditForm(string name)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM biography WHERE name = @name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TextBox1.Text = reader["name"].ToString();
                    TextBox2.Text = reader["phoneno"].ToString();
                    TextBox3.Text = reader["email"].ToString();
                    TextBox4.Text = reader["password"].ToString();
                    TextBox5.Text = reader["id"].ToString();
                    
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-ERN1FTED;Initial Catalog=Student;Integrated Security=True;Encrypt=False");
        

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
            try
            {
                string name = TextBox1.Text;
                int phoneno = int.Parse(TextBox2.Text);
                string email = TextBox3.Text;
                string passw = TextBox4.Text;
                int id = int.Parse(TextBox5.Text);
                Console.WriteLine(passw);

                conn.Open();
                string query = "UPDATE biography SET  phoneno=@phoneno,name=@name, email=@email, password=@passw WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phoneno", phoneno);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@passw", passw);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Optionally, you can redirect the user to another page after the update
                Response.Redirect("WebForm4.aspx");
            }
            catch (Exception exception)
            {
                // Handle exceptions
                Console.WriteLine(exception.ToString());
            }
        }


    }
}