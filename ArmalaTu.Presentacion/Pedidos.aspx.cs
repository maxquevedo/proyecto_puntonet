using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArmalaTu.Datos;
using ArmalaTu.Negocio;

namespace ArmalaTu.Presentacion
{
    public partial class Pedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido ped = new Pedido()
                {
                    ID_Pedido = int.Parse(TxtIDpedido.Text)
                };
                if (ped.Read())
                {
                    txtnombre.Text = ped.NombreCliente;
                    txtdireccion.Text = ped.Direccion;
                    txtbebida.Text = ped.Bebida;
                    ddServir.Text = ped.Servir;
                    TxtID_pizza.Text = ped.ID_pizza;
                    txtdescuento.Text = ped.Descuento;
                    TxtTotal = ped.Total;
                }
                else
                {
                    lbmessage.Text = "NO Encontrado";
                    txtdireccion.Text = "";
                    txtnombre.Text = "";
                }
            }
            catch (Exception ex)
            {
                txtdireccion.Text = "";
                txtnombre.Text = "";
                lbmessage.Text = ex.Message;

            }
        }

        protected void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                pedido pedi = new pedido()
                {
                    id_pedido = TxtIDpedido.Text;
                    pedi.direccion = txtdireccion.Text;
                    pedi.bebida = txtbebida.Text;
                    pedi.servir = ddServir.Text;
                    pedi.id_pizza = TxtID_pizza.Text;
                    pedi.descuento = txtdescuento.Text;
                    pedi.total = TxtTotal;
                };
                if (Pedido.Create())
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}