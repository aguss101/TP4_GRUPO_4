using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TP4_GRUPO_4
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private const string dataBaseTravel = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True;Encrypt=False";
        private string querySQL = "SELECT * FROM Localidades";
        private string querySQL2 = "SELECT * FROM Provincias";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(dataBaseTravel);
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(querySQL, connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            ddlLocalidad.DataSource = sqlDataReader;

            ddlLocalidad.DataTextField = "NombreLocalidad";
            ddlLocalidad.DataValueField = "IdLocalidad";

            ddlLocalidad.DataBind();




        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainForm.aspx");
        }
    }
}