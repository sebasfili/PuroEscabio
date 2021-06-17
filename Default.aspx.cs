﻿using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuroEscabio
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var usuarioLogueado = Session["UsuarioLogueado"] as UsuarioBE;

            lblRolUsuario.Text = usuarioLogueado?.PerfilDeUsuario?.Descripcion;

        }

      
    }
}