using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP4_GRUPO_4
{
    public partial class Ejercicio_2 : System.Web.UI.Page
    {
    private const string dataBaseNeptuno = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=False";
        private string querysql = "SELECT IDProducto,NombreProducto,IDCategoría,CantidadPorUnidad,PrecioUnidad FROM Productos";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarProductos();
                
            }
        }


        protected void cargarProductos(string filtroProducto = "", string filtroCategoria = "")
        {

            using (SqlConnection connection = new SqlConnection(dataBaseNeptuno))
            {
                connection.Open();

                SqlDataAdapter sqldataadapter = new SqlDataAdapter(querysql, connection);
                DataSet dataset = new DataSet();
                sqldataadapter.Fill(dataset, "TablaProductos");

                DataTable productos = dataset.Tables["TablaProductos"];

                string filterExpression = "";

                
                if (!string.IsNullOrEmpty(filtroProducto))
                {
                    
                    if (ddlIDProduct.SelectedValue == "0") filterExpression += $"IdProducto = {filtroProducto}";
                    else if (ddlIDProduct.SelectedValue == "1") filterExpression += $"IdProducto > {filtroProducto}";
                    else if (ddlIDProduct.SelectedValue == "-1") filterExpression += $"IdProducto < {filtroProducto}";
                    txt_IDp.Text = "";
                }

               
                if (!string.IsNullOrEmpty(filtroCategoria))
                {
                 
                    if (!string.IsNullOrEmpty(filterExpression)) filterExpression += " AND ";
                   
                    if (ddlIDCategory.SelectedValue == "0") filterExpression += $"IdCategoría = {filtroCategoria}";
                    else if (ddlIDCategory.SelectedValue == "1") filterExpression += $"IdCategoría > {filtroCategoria}";
                    else if (ddlIDCategory.SelectedValue == "-1") filterExpression += $"IdCategoría < {filtroCategoria}";
                    txt_IDc.Text = "";
                }

               
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    productos.DefaultView.RowFilter = filterExpression;
                }

                gvProductos.DataSource = productos;
                gvProductos.DataBind();
                connection.Close();
            }

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtroProducto = txt_IDp.Text;
            string filtroCategoria = txt_IDc.Text;

            cargarProductos(filtroProducto, filtroCategoria);
        }


        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainForm.aspx");
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        protected void btnQuitar_Filtro_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(dataBaseNeptuno))
            {
                connection.Open();

                SqlDataAdapter sqldataadapter = new SqlDataAdapter(querysql, connection);
                DataSet dataset = new DataSet();
                sqldataadapter.Fill(dataset, "TablaProductos");

                DataTable productos = dataset.Tables["TablaProductos"];

                gvProductos.DataSource = productos;
                gvProductos.DataBind();
            }
        }
    }
}