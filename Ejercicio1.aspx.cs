using System;
using System.Collections.Generic;
using System.Data;
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
            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(dataBaseTravel);
                connection.Open();

                //Carga localidades en ddlLocalidad
                SqlCommand sqlCommand = new SqlCommand(querySQL, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                ddlLocalidad.DataSource = sqlDataReader;

                ddlLocalidad.DataTextField = "NombreLocalidad";
                ddlLocalidad.DataValueField = "IdLocalidad";

                ddlLocalidad.DataBind();

                sqlDataReader.Close();
                //Carga provincias en ddlProvincia
                SqlCommand sqlCommand2 = new SqlCommand(querySQL2, connection);
                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();

                ddlProvincia.DataSource = sqlDataReader2;
                ddlProvincia.DataTextField = "NombreProvincia";
                ddlProvincia.DataValueField = "IdProvincia";
                ddlProvincia.DataBind();

                sqlDataReader2.Close();
                //Carga provincias en ddlProvinciaB
                SqlCommand sqlCommand3 = new SqlCommand(querySQL2, connection);
                SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();

                ddlProvinciaB.DataSource = sqlDataReader3;
                ddlProvinciaB.DataTextField = "NombreProvincia";
                ddlProvinciaB.DataValueField = "IdProvincia";
                ddlProvinciaB.DataBind();

                sqlDataReader3.Close();
                //Carga localidades en ddllocalidadB
                SqlCommand sqlCommand4 = new SqlCommand(querySQL, connection);
                SqlDataReader sqlDataReader4 = sqlCommand4.ExecuteReader();

                ddlLocalidadB.DataSource = sqlDataReader4;
                ddlLocalidadB.DataTextField = "NombreLocalidad";
                ddlLocalidadB.DataValueField = "IdLocalidad";
                ddlLocalidadB.DataBind();

                sqlDataReader4.Close();
                connection.Close();

                ddlProvincia.Items.Insert(0, new ListItem("--- Seleccione una provincia ---", "0"));
                ddlProvinciaB.Items.Insert(0, new ListItem("--- Seleccione una provincia ---", "0"));
                ddlLocalidad.Items.Insert(0, new ListItem("--- Seleccione una localidad ---", "0"));
                ddlLocalidadB.Items.Insert(0, new ListItem("--- Seleccione una localidad ---", "0"));
            }
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainForm.aspx");
        }
        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Codigo a ejecutar cuando cambias la provincia
        }
        protected void ddlProvinciaB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void ddlLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void ddlLocalidadB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}