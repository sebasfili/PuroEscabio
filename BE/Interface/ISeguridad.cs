using BE.Composite;
using System.Collections.Generic;

namespace BE.Interface
{
    public interface ISeguridad
    {
        string GenerarTokenDeSesion(UsuarioBE user);
        bool BorrarTokenDeSesion(UsuarioBE user);
        string RenovarTokenDeSesion(UsuarioBE user);
        bool ValidarIntegridadDeAplicacion(UsuarioBE user);
        bool GenerarDigitoVerificadorVertical();//podría ser sobre precio de producto.
        bool GenerarDigitoVerificadorHorizontal();//podría ser sobre usuario
        void CrearBitacora(UsuarioBE user, string action);//registrar ingreso y egreso de usuario. BackUp y Restore
        bool CrearBackUpBD(string BDName);
        bool RestoreBD(string BDName);
        List<string> ObtenerBackUps();
        string EncriptarClaveDeUsuario(string password);
        List<BitacoraBE> ObtenerBitacoraCompleta();
        List<RolPatenteBE> ObtenerPermisosDeUsuario(UsuarioBE user);
    }
}
