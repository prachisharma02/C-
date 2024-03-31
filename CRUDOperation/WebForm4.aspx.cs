using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CRUDOperation
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                Bindgrid();
                LoadNames();
                
            }
        }
        protected void Bindgrid()
        {
            string query = "select * from biography";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            grid.DataSource = data;
            grid.DataBind();

        }
        protected void grid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grid.EditIndex = e.NewEditIndex;
            Bindgrid(); // Re-bind the data to display the selected row in edit mode (optional)
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-ERN1FTED;Initial Catalog=Student;Integrated Security=True;Encrypt=False");

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = (Button)sender;
                GridViewRow clickedRow = clickedButton.NamingContainer as GridViewRow;
                var label = clickedRow.FindControl("Label1") as Label;
                string name = label.Text;

                string query = "DELETE FROM biography WHERE name=@name";        
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
               // Re-bind the GridView after deleting the row
                Bindgrid();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string name = clickedButton.CommandArgument;
            Response.Redirect($"WebForm5.aspx?name={name}");
        }
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            if (name == "")
            {
               
                table.Text += "NO MATCHING RECORDS";

            }
            else
            {
                try
                {
                    conn.Open();
                    string query2 = "global";
                    ;
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter = new SqlParameter("@name", name);
                    cmd.Parameters.Add(parameter);
                    SqlDataReader reader = cmd.ExecuteReader();
                    litTableBody.Text = "";
                    while (reader.Read())
                    {
                        litTableBody.Text += "<tr>";
                        litTableBody.Text += "<td>" + reader["id"].ToString() + "</td>";
                        litTableBody.Text += "<td>" + reader["Name"].ToString() + "</td>";
                        litTableBody.Text += "<td>" + reader["PhoneNo"].ToString() + "</td>";
                        litTableBody.Text += "<td>" + reader["Email"].ToString() + "</td>";
                        litTableBody.Text += "<td>" + reader["Password"].ToString() + "</td>";
                        litTableBody.Text += "</tr>";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
        protected void Namefind(object sender, EventArgs e)
        {
            string name = TextBox2.Text.Trim();
            if (name == "")
            {
                Literal3.Text += "NO MATCHING RECORDS";
            }
            else
            {
                try
                {
                    conn.Open();
                    string query2 = "localn";
                    ;
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter = new SqlParameter("@name", name);
                    cmd.Parameters.Add(parameter);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Literal3.Text = "";
                    while (reader.Read())
                    {
                        Literal3.Text += "<tr>";
                        Literal3.Text += "<td>" + reader["Name"].ToString() + "</td>";
                        Literal3.Text += "</tr>";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        protected void Numfind(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBox3.Text.Trim(), out int num))
            {
                Literal4.Text = "Invalid input for phone number.";
                return;
            }

            Literal4.Text = ""; // Clear previous content
            try
            {
                conn.Open();
                string query3 = "localno";
                SqlCommand cmd2 = new SqlCommand(query3, conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter2 = new SqlParameter("@Phoneno", SqlDbType.Int); // Use SqlDbType.Int for integer type
                parameter2.Value = num; // Set the parameter value
                cmd2.Parameters.Add(parameter2);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    Literal4.Text += "<tr>";
                    Literal4.Text += "<td>" + reader2["PhoneNo"].ToString() + "</td>";
                    Literal4.Text += "</tr>";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close(); 
            }
        }


        protected void Efind(object sender, EventArgs e)
        {
            string email = TextBox4.Text.Trim();
            Literal5.Text = "";
            if (string.IsNullOrWhiteSpace(email))
            {
                Label5.Text = "NO MATCHING RECORDS"; 
            }
            else
            {
                try
                {
                    conn.Open();
                    string query2 = "localem";
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter = new SqlParameter("@email", email); 
                    cmd.Parameters.Add(parameter);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Literal5.Text += "<tr>";
                        Literal5.Text += "<td>" + reader["Email"].ToString() + "</td>";
                        Literal5.Text += "</tr>";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    conn.Close(); 
                }
            }
        }
        public void LoadNames()
        {
            try
            {                
                    conn.Open();

                    string query = "SELECT Name FROM biography";

                SqlCommand cmd = new SqlCommand(query, conn);
                    
                       SqlDataReader reader = cmd.ExecuteReader();
                        
                            offcanvasBody.InnerHtml = "";

                            while (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                offcanvasBody.InnerHtml += $"<div>{name}</div>";
                            }
                        
                    
                
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine(ex);
            }
        }



    }
}