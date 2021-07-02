using BE;
using BLL;
using System;
using System.Text;
using System.Web.Security;

namespace PuroEscabio.Login
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            var persona = new PersonaBE()
            {
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                DNI = int.Parse(txtDNI.Text),
                Nombre = txtNombre.Text,
                ProvinciaEstado = txtCiudad.Text,
                PaisID = int.Parse(dpPais.SelectedValue)
            };
            
            var seguridad = new SeguridadBLL();

            var usuario = new UsuarioBE()
            {
                NombreDeUsuario = txtEmail.Text,
                Password = seguridad.EncriptarClaveDeUsuario(txtPassword.Text),
                PerfilDeUsuario = new PerfilBE() { Descripcion = "Usuario", Id = 5 }
            };

            var registrarBll = new LogInBLL();
            UsuarioBE newUser = registrarBll.RegistrarUsuario(usuario, persona);

            if (newUser.Id != 0)
            {

                FormsAuthentication.RedirectToLoginPage();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        protected void CheckboxValidator_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {

        }
    }
}