namespace BE.Interface
{
    public interface ILogIn
    {
        UsuarioBE ObtenerLoginIn(UsuarioBE user);
        UsuarioBE RegistrarUsuario(UsuarioBE user);
        bool ValidarSesion(UsuarioBE user);        
        bool BorrarUsuario(UsuarioBE user);
        UsuarioBE ModificarUsuario(UsuarioBE user);
    }
}
