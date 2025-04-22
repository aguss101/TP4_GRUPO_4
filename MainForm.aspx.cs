using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_4
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnEj1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio1.aspx");
        }

        protected void btnEj2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2.aspx");
        }

        protected void btnEj3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3.aspx");
        }
    }
}