namespace BE.Interface
{
    public interface ILogIn
    {
        Usuario ObtenerLoginIn(Usuario user);
        Usuario RegistrarUsuario(Usuario user);
        bool ValidarSesion(Usuario user);        
        bool BorrarUsuario(Usuario user);
        Usuario ModificarUsuario(Usuario user);
    }
}
