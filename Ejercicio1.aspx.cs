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

                while (sqlDataReader.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = sqlDataReader["NombreLocalidad"].ToString();
                    item.Value = sqlDataReader["IdProvincia"].ToString();
                    item.Attributes["Provincia"] = sqlDataReader["IdProvincia"].ToString();
                    ddlLocalidad.Items.Add(item);
                    ddlLocalidadB.Items.Add(item);
                }
                sqlDataReader.Close();
                //Carga provincias en ddlProvincia
                SqlCommand sqlCommand2 = new SqlCommand(querySQL2, connection);
                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();

                while (sqlDataReader2.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = sqlDataReader2["NombreProvincia"].ToString();
                    item.Value = sqlDataReader2["IdProvincia"].ToString();
                    ddlProvincia.Items.Add(item);
                    ddlProvinciaB.Items.Add(item);
                }
                sqlDataReader2.Close();
                connection.Close();
            }
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainForm.aspx");
        }
        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlProvincia.SelectedIndex == 0)
            {
                foreach(ListItem item in ddlLocalidad.Items) item.Enabled = true;
                foreach(ListItem item in ddlProvinciaB.Items) item.Enabled = true;
            }
            else
            {
                foreach (ListItem item in ddlLocalidad.Items)
                {
                    if (item.Value == ddlProvincia.SelectedValue) item.Enabled = true;
                    else if (item.Value != "0") item.Enabled = false;
                }

                foreach (ListItem item in ddlProvinciaB.Items)
                {
                    if (item.Value == ddlProvincia.SelectedValue) item.Enabled = false;
                    else item.Enabled = true;
                }
            }
                
            ddlLocalidad.SelectedValue = "0";
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