using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmalaTu.Datos;

namespace ArmalaTu.Negocio
{
    public class Pedido
    {
        #region Atributos
        private int id_pedido;
        private string _nombreCliente;
        private string _direccion;
        private string _bebida;
        private string _servir;
        private int id_pizza;
        private int _descuento;
        private int _total;

        #endregion

        #region Propiedades
        public int ID_Pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }

        public string NombreCliente
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Bebida
        {
            get { return _bebida; }
            set { _bebida = value; }
        }
 
        public string Servir
        {
            get { return _servir; }
            set { _servir = value; }
        }
 
        public int Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public int ID_pizza
        {
            get { return id_pizza; }
            set { id_pizza = value; }
        }

        #endregion

        #region Constructores
        public Pedido()
        {
            this.Index();
        }

        public void Index()
        {
            id_pedido = 0;
            _nombreCliente = "";
            _direccion = "";
            _bebida = "";
            _servir = "";
            id_pizza = 0;
            _descuento = 0;
            _total = 0;
        }
        #endregion 

        //Crud

        //Create 

        public bool Create()
        {
            try
            {
                //Objeto que entra en la base de datos
                Datos.pedido ped = new Datos.pedido()
                {
                    id_pedido = id_pedido,
                    nombre_cliente = _nombreCliente,
                    direccion = _direccion,
                    bebida = _bebida,
                    servir = _servir,
                    descuento = _descuento,
                    total = _total
                };
                Conexion.PedidosBD.pedido.Add(ped);
                Conexion.PedidosBD.SaveChanges();
                //abre la conexion, hace el comando SQL, actualiza la BD y cierra la conexion.

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Read 

        public bool Read()
        {
            try
            {
                Datos.pedido ped = Conexion.PedidosBD.pedido.First(em => em.id_pedido == id_pedido);
                id_pedido = ped.id_pedido;
                NombreCliente = ped.nombre_cliente;
                Direccion = ped.direccion;
                Bebida = ped.bebida;
                Servir = ped.servir;
                Descuento =ped.descuento;
                Total = ped.total;


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Update 

        public bool Update()
        {
            try
            {
                Datos.pedido ped = Conexion.PedidosBD.pedido.First(em => em.id_pedido == id_pedido);
                ped.id_pedido = id_pedido;
                ped.nombre_cliente = NombreCliente;
                ped.direccion = Direccion;
                ped.bebida = Bebida;
                ped.servir = Servir;
                ped.descuento = Descuento;
                ped.total = Total;
                Conexion.PedidosBD.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Delete

        public bool Delete()
        {
            try
            {
                Datos.pedido ped = Conexion.PedidosBD.pedido.First(em => em.id_pedido == id_pedido);
                Conexion.PedidosBD.pedido.Remove(ped);
                Conexion.PedidosBD.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public int getIDpedido()
        {
            return id_pedido;
        }


    }
}
