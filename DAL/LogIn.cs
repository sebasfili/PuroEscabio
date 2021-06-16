using BE;
using System.Linq;

namespace DAL
{
    public class LogIn
    {
        public UsuarioBE ObtenerLogIn(UsuarioBE user)
        {
            /*generar un linq a la base para obtener el usuario con rol y cargarlo en la sesion
             Obtener las patentes
            */
            using (var dbContext = new PuroEscabioDataContext())
            {
                var resultado = (from usuario in dbContext.Usuarios
                                 where usuario.Usuario1.ToLower().Trim() == user.NombreDeUsuario.ToLower().Trim()
                                  && string.Compare(usuario.Contraseña, user.Password) == 0
                                 select usuario).FirstOrDefault();
                if (resultado != null)
                {
                    var usuarioActual = new UsuarioBE()
                    {
                        Id = resultado.Id,
                        NombreDeUsuario = resultado.Usuario1,
                        Password = resultado.Contraseña
                    };

                    return usuarioActual;
                }
                else
                {
                    return new UsuarioBE()
                    {
                        Id = -1,
                        NombreDeUsuario = "test",
                        Password = "test-password"
                    };
                }
            }

        }
    }
}
