﻿using BE.Composite;
using System.Collections.Generic;

namespace BE.Interface
{
    public interface ISeguridad
    {
        string GenerarTokenDeSesion(UsuarioBE user);
        bool BorrarTokenDeSesion(UsuarioBE user);
        string RenovarTokenDeSesion(UsuarioBE user);
        bool ValidarIntegridadDeAplicacion(UsuarioBE user);
        void RecalcularDigitoVerificadorVerticalTodos();
        void RecalcularDigitoVerificadorHorizontalTodos();
        void CrearBitacora(UsuarioBE user, string action);
        bool CrearBackUpBD(string BDName);
        bool RestoreBD(string BDName);
        List<string> ObtenerBackUps();
        string EncriptarClaveDeUsuario(string password);
        List<BitacoraBE> ObtenerBitacoraCompleta();
        List<RolPatenteBE> ObtenerPermisosDeUsuario(UsuarioBE user);
    }
}
