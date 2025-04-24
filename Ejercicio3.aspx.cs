using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_GRUPO_4
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        private const string dataBaseLibrary = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True;Encrypt=False";
        private string querySQL = "SELECT Tema FROM Temas";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //SqlConnection connection = new SqlConnection(dataBaseLibrary);
                //connection.Open();

                //SqlCommand sqlCommand = new SqlCommand(querySQL,connection);
                //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //ddlThemes.DataSource = sqlDataReader;
                //ddlThemes.DataBind();
                //connection.Close();

                
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainForm.aspx");
        }
    }
}