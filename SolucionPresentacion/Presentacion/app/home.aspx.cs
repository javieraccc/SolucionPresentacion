using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Trabajador usuario = (Trabajador)Session["usuario"];

            //if (usuario != null)
            //{
            //    if ('A' == usuario.Perfil || 'U' == usuario.Perfil)
            //    {
            //        lbl_datos_usuario.Text = "Bienvenido " +  usuario.Nombres + " " + usuario.Apellidos  + "(" + usuario.Perfil + ")";
            //    }
            //    else
            //    {
            //        Response.Redirect("login.aspx");
            //    }
            //}
            //else
            //{
            //    Response.Redirect("login.aspx");
            //}
        }
    }
}