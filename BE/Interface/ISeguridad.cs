using BE.Composite;
using System.Collections.Generic;

namespace BE.Interface
{
    public interface ISeguridad
    {
        string GenerarTokenDeSesion(UsuarioBE user);
        bool BorrarTokenDeSesion(UsuarioBE user);
        string RenovarTokenDeSesion(UsuarioBE user);
        bool ValidarIntegridadDeAplicacion();
        void RecalcularDigitoVerificadorVerticalTodos();
        void RecalcularDigitoVerificadorHorizontalTodos();
        void CrearBitacora(UsuarioBE user, string action);
        bool CrearBackUpBD(string BDName, string targetPath);
        bool RestoreBD(string BDName);
        List<BackUp> ObtenerBackUps(string path);
        string EncriptarClaveDeUsuario(string password);
        List<BitacoraBE> ObtenerBitacoraCompleta();
        List<RolPatenteBE> ObtenerPermisosDeUsuario(UsuarioBE user);
    }
}
