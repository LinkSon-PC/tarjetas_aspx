using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tarjetas_asp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Puedes realizar alguna inicialización si es necesario
            }

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                // Esto no debería ocurrir debido a la validación del lado del cliente.
                // Pero se incluye por seguridad.
                Response.Write("<script>alert('Por favor, complete todos los campos.');</script>");
                return;
            }

            // Aquí puedes agregar la lógica para validar las credenciales del usuario.
            if (username == "admin" && password == "password")
            {
                Response.Write("<script>alert('Login exitoso');</script>");
                // Si las credenciales son correctas, redireccionar a la página de inicio o realizar alguna acción
                Response.Redirect("tarjeta.aspx");
            }
            else
            {
                Response.Write("<script>alert('Credenciales incorrectas');</script>");
            }
        }
    }
}