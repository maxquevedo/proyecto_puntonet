using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmalaTu.Datos;
namespace ArmalaTu.Negocio
{
    public class ListarPedido
    {
        public List<Pedido> ListadoPedidos()
        {
            List<Pedido> salida = new List<Pedido>();

            foreach (Datos.pedido datosPedido in Conexion.PedidosBD.pedido)
            {
                salida.Add(
                    new Pedido()
                    {
                        ID_Pedido = datosPedido.id_pedido,
                        NombreCliente = datosPedido.nombre_cliente,
                        Direccion = datosPedido.direccion,
                        Bebida = datosPedido.bebida,
                        Servir = datosPedido.servir,
                        ID_pizza = datosPedido.id_pizza,
                        Descuento = datosPedido.descuento,
                        Total = datosPedido.total

                    });
            }

            return salida;
        }
    }
}
