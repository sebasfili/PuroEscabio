﻿using BLL;
using PuroEscabio.wsPuroEscabio;
using System;
using System.Web.UI.WebControls;

namespace PuroEscabio.Security
{
    public partial class Stock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var ws = new WebService1();
                var result = ws.PedidoDeStock();

                gvStock.DataSource = result.ProductosEnStock;
                gvStock.AutoGenerateColumns = true;
                gvStock.DataBind();

                gvNoStock.DataSource = result.ProductosARenovar;
                gvNoStock.AutoGenerateColumns = true;
                gvNoStock.DataBind();

                ObtenerSucursales();

            }
        }

        private void ObtenerSucursales()
        {
            var seguridad = new SeguridadBLL();
            var result = seguridad.ObtenerSucursales();

            dpSucursales.DataSource = null;
            dpSucursales.Items.Clear();

            dpSucursales.Items.Add(new ListItem() { Text = "Selecciona una Sucursal", Value = "NoSucursal" });

            result.ForEach(suc =>
            {
                var listItem = new ListItem()
                {
                    Text = suc.Descripcion,
                    Value = suc.Id.ToString()
                };
                dpSucursales.Items.Add(listItem);
            });


            dpSucursales.DataBind();

        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        protected void dpSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorSucursal.Visible = false;


            if (dpSucursales.SelectedValue != "NoSucursal")
            {
                lblGridInfo1.Visible = false;
                lblGridInfo2.Visible = false;

                var ws = new WebService1();
                int idSucursal = int.Parse(dpSucursales.SelectedValue);

                var result = ws.PedidoDeStockPorSucursal(idSucursal);

                gvSucStock.DataSource = result.ProductosEnStock;
                gvSucStock.AutoGenerateColumns = true;
                gvSucStock.DataBind();


                gvSucNoStock.DataSource = result.ProductosARenovar;
                gvSucNoStock.AutoGenerateColumns = true;
                gvSucNoStock.DataBind();


                updateGrids.Update();

            }
            else
            {
                lblErrorSucursal.Visible = true;
                lblGridInfo1.Visible = true;
                lblGridInfo2.Visible = true;

                gvSucStock.DataSource = null;
                gvSucStock.AutoGenerateColumns = true;
                gvSucStock.DataBind();


                gvSucNoStock.DataSource = null;
                gvSucNoStock.AutoGenerateColumns = true;
                gvSucNoStock.DataBind();

                updateGrids.Update();

            }
        }
    }
}