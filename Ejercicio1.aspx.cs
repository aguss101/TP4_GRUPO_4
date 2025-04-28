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
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                inicializateDropDownLists();
            }
        }

        public void inicializateDropDownLists()
        {
            ddlProvincia.DataSource = Consultar("SELECT * FROM Provincias");
            ddlProvincia.DataTextField = "NombreProvincia";
            ddlProvincia.DataValueField = "IdProvincia";
            ddlProvincia.DataBind();
            ddlProvincia.Items.Insert(0, new ListItem("[Seleccionar Provincia Inicio]", "0"));
            ddlProvinciaDestino.Items.Insert(0, new ListItem("[Seleccionar Provincia Destino]", "0"));
            ddlLocalidad.Items.Insert(0, new ListItem("[Seleccionar Localidad Inicio]", "0"));
            ddlLocalidadB.Items.Insert(0, new ListItem("[Seleccionar Localidad Destino]", "0"));
            
        }
        public DataSet Consultar(string strSQL)
        {
            string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";
            SqlConnection con = new SqlConnection(strConn);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }


        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainForm.aspx");
        }
        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

            int IdProvincia = Convert.ToInt32(ddlProvincia.SelectedValue);
            ddlLocalidad.DataSource = Consultar("SELECT * FROM Localidades WHERE IdProvincia=" + IdProvincia);
            ddlLocalidad.DataTextField = "NombreLocalidad";
            ddlLocalidad.DataValueField = "IdLocalidad";
            ddlLocalidad.DataBind();
            ddlLocalidad.Items.Insert(0, new ListItem("[Seleccionar Localidad Inicio]", "0"));



            ddlProvinciaDestino.DataSource = Consultar("SELECT * FROM Provincias WHERE IdProvincia <> " + IdProvincia);
            ddlProvinciaDestino.DataTextField = "NombreProvincia";
            ddlProvinciaDestino.DataValueField = "IdProvincia";
            ddlProvinciaDestino.DataBind();
            ddlProvinciaDestino.Items.Insert(0, new ListItem("[Seleccionar Provincia Destino]", "0"));

            // Volver a valor inicial el ddlLocalidadB
            ddlLocalidadB.Items.Clear();
            ddlLocalidadB.Items.Insert(0, new ListItem("[Seleccionar Localidad Destino]", "0"));
        }
        protected void ddlProvinciaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idProvinciaDestino = Convert.ToInt32(ddlProvinciaDestino.SelectedValue);
            ddlLocalidadB.DataSource = Consultar("SELECT * FROM Localidades WHERE IdProvincia=" + idProvinciaDestino);
            ddlLocalidadB.DataTextField = "NombreLocalidad";
            ddlLocalidadB.DataValueField = "IdLocalidad";
            ddlLocalidadB.DataBind();
            ddlLocalidadB.Items.Insert(0, new ListItem("[Seleccionar Localidad Destino]", "0"));
        }
        protected void ddlLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void ddlLocalidadB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}