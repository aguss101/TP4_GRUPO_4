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

        protected void cargarProductos(string filtro = "")
        {
            using (SqlConnection connection = new SqlConnection(dataBaseNeptuno))
            {
                connection.Open();

                SqlDataAdapter sqldataadapter = new SqlDataAdapter(querysql, connection);
                DataSet dataset = new DataSet();
                sqldataadapter.Fill(dataset, "TablaProductos");

                DataTable productos = dataset.Tables["TablaProductos"];

                if (!string.IsNullOrEmpty(filtro))
                {
                    string filterExpression = "";

                    if (ddlIDProduct.SelectedValue == "0") filterExpression = $"IdProducto = {filtro}";
                    else if (ddlIDProduct.SelectedValue == "1") filterExpression = $"IdProducto > {filtro}";
                    else if (ddlIDProduct.SelectedValue == "-1") filterExpression = $"IdProducto < {filtro}";

                    productos.DefaultView.RowFilter = filterExpression;
                }

                gvProductos.DataSource = productos;
                gvProductos.DataBind();
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainForm.aspx");
        }
        protected void TbIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbIdProducto.Text, out int idValue))
            {
                cargarProductos(idValue.ToString());
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}