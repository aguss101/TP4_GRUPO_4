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
                // Establecer la conexión a la base de datos
                SqlConnection connection = new SqlConnection(dataBaseLibrary);
                connection.Open();

                // Consulta SQL que se desea ejecutar

                SqlCommand sqlCommand = new SqlCommand(querySQL,connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                ///ddlThemes.DataSource = sqlDataReader;
                ///ddlThemes.DataBind();
                connection.Close();

                
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainForm.aspx");
        }

        protected void lbBooks_Click(object sender, EventArgs e)
        {
            string temaSeleccionado = (ddlThemes.SelectedIndex + 1).ToString();
            Response.Redirect("Ejercicio3b.aspx?tema=" + temaSeleccionado);
        }

        protected void ddlThemes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataLibrary_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}