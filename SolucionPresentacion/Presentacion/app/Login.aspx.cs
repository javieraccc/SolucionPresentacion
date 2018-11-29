using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app.site.template
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            // Al hacer la referencia de los servicios, nombrar el archivo(Video 8) 
            //descomentar lo siguiente una vez hechas las referencias y los using

            //Service1Client usr = new Service1Client();
            //MensajeAutenticacion mensaje = usr.autenticacion(txt_usuario.Text, txt_password.Text);

            //if (mensaje.Mensaje.TransaccionOk) //deje los nombres que da el profe porque no se cual pusiste. reemplazar.
            //{
            //    Session["usuario"] = mensaje.Usuario;

            Response.Redirect("home.aspx");
            //}
            //else
            //{
            //    lbl_mensaje_error.Text = mensaje.Mensaje.MensajeError;
            //}

        }
    }
}