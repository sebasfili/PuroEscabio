using System.Collections.Generic;

namespace BE.Interface
{
    public interface ISeguridad
    {
        string GenerarTokenDeSesion(Usuario user);
        bool BorrarTokenDeSesion(Usuario user);
        string RenovarTokenDeSesion(Usuario user);
        bool ValidarIntegridadDeAplicacion(Usuario user);
        bool GenerarDigitoVerificadorVertical();//podría ser sobre precio de producto.
        bool GenerarDigitoVerificadorHorizontal();//podría ser sobre usuario
        void CrearBitacora(Usuario user);//registrar ingreso y egreso de usuario. BackUp y Restore
        bool CrearBackUpBD(string BDName);
        bool RestoreBD(string BDName);
        List<string> ObtenerBackUps();
        string EncriptarClaveDeUsuario(string password);
    }
}
