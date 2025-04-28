using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_4
{
    public partial class Ejercicio3b : System.Web.UI.Page
    {
        private const string dataBaseLibrary = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True;Encrypt=False";
        private string querySQL = "SELECT * FROM Temas WHERE Tema = @Tema"; // filtramos por el tema recibido
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string tema = Request.QueryString["tema"];

                if (!string.IsNullOrEmpty(tema))
                {
                    lblTemaSeleccionado.Text = "Tema seleccionado: " + tema;
                    CargarDatos(tema); // Función hecha abajo
                }
                else
                {
                    lblTemaSeleccionado.Text = "No se recibió un tema.";
                }
            }
        }

        private void CargarDatos(string tema)
        {
            {
                // Establecer la conexión a la base de datos

                SqlConnection connection = new SqlConnection(dataBaseLibrary);
                connection.Open();

                // Consulta SQL que se desea ejecutar

                SqlCommand sqlCommand = new SqlCommand(querySQL, connection);
                sqlCommand.Parameters.AddWithValue("@Tema", tema);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet,"TablaLibros");
                
                // La tabla ya es bindeada y tiene source debido a la propiedad DataSourceID

                connection.Close();

            }
        }
        protected void lbVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3.aspx");
        }
       
    }
}