using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmalaTu.Datos;

namespace ArmalaTu.Negocio
{
    public class Pizza
    {
        #region Atributos
        private int _idPizza;
        private string _tipoPago;
        private string nombre_pizza;
        private string _tipoMasa;
        private string _dosPorUno;
        private int _price;
        #endregion

        #region Propiedades
        public int IDPizza
        {
            get { return _idPizza; }
            set { _idPizza = value; }
        }

        public string TipoPago
        {
            get { return _tipoPago; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El tipo de pago no puede estar vacio");
                }
                _tipoPago = value;
            }
        }

        public string Nombre_pizza
        {
            get { return nombre_pizza; }
            set { nombre_pizza = value; }
        }

        public string TipoMasa
        {
            get { return _tipoMasa; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El tipo de Masa no puede estar vacio");
                }
                _tipoMasa = value;
            }
        }

        public string Tamaño { get; set; }

        public string DosPorUno
        {
            get { return _dosPorUno; }
            set
            {
                if (value != "S" || value != "N" || value != "s" || value != "n")
                {
                    throw new ArgumentException("El DosPorUno por uno debe ser S (Si)  o  N (No)");
                }
                _dosPorUno = value;
            }
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("El precio no puede ir vacio");
                }
                _price = value;
            }
        }

        #endregion

        #region Constructores
        public Pizza()
        {
            Inicializador();
        }

        public void Inicializador()
        {
            _idPizza = 0;
            _tipoPago = "";
            _tipoMasa = "";
            Tamaño = "";
            _dosPorUno = "";
            nombre_pizza = "";
            _price = 0;

        }
        #endregion

        #region Metodos
        public bool Create()
        {
            try
            {
                //Objeto que entra en la base de datos
                Datos.pizza objetoPizza = new Datos.pizza()
                {
                    id = _idPizza,
                    tipo_pago = _tipoPago,
                    masa = _tipoMasa,
                    tamaño = Tamaño,
                    dos_por_uno = _dosPorUno,
                    nombre_pizza = nombre_pizza,
                    precio = _price


                };
                Conexion.PedidosBD.pizza.Add(objetoPizza);
                Conexion.PedidosBD.SaveChanges();

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
                Datos.pizza pizzaDatos = (
                    from piz in Conexion.PedidosBD.pizza
                    where piz.id == _idPizza
                    select piz
                    ).First();
                _tipoPago = pizzaDatos.tipo_pago;
                _tipoMasa = pizzaDatos.masa;
                Tamaño = pizzaDatos.tamaño;
                DosPorUno = pizzaDatos.dos_por_uno;
                Nombre_pizza = pizzaDatos.nombre_pizza;
                _price = pizzaDatos.precio;

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Datos.pizza piz = Conexion.PedidosBD.piz.First(em => em.id == _idPizza);
                piz.id = _idPizza;
                piz.tipo_pago = TipoPago;
                piz.masa = TipoMasa;
                piz.tamaño = Tamaño;
                piz.dos_por_uno = DosPorUno;
                piz.nombre_pizza = nombre_pizza;
                piz.precio = _price;
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
                Datos.pizza piz = Conexion.PedidosBD.pizza.First(em => em.id == _idPizza);
                Conexion.PedidosBD.pizza.Remove(piz);
                Conexion.PedidosBD.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}