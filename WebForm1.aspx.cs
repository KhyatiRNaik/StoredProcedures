using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace StoredProcedures
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowEmpName_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Documents\khyati.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("showName", conn);
            SqlDataReader dr;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "showName";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                conn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = "Error: " + ex.ToString();
            }
        }
    }
}