using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArmalaTu.Negocio;
using ArmalaTu.Datos;

namespace ArmalaTu.Presentacion
{
    public partial class ListadoPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPedido();
            }
        }

        private void LoadPedido()
        {
            ListarPedido pedidos = new ListarPedido();
            gvPedidos.DataSource = pedidos.ListadoPedidos();
            gvPedidos.DataBind();
        }

        protected void gvPedidos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPedidos.PageIndex = e.NewPageIndex;
            LoadPedido();
        }
    }
}