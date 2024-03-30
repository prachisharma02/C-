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
            if (!IsPostBack) // Only fetch data on initial page load
            {
                Bindgrid();
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


    }
}