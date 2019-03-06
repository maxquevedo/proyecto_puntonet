using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmalaTu.Datos;

namespace ArmalaTu.Negocio
{
    internal class Conexion
    {
        private static ArmalaTuEntities _pedidosBD;

        public static ArmalaTuEntities PedidosBD
        {
            get
            {
                if (_pedidosBD == null)
                {
                    _pedidosBD = new ArmalaTuEntities();
                }
                return _pedidosBD;
            }

            set { _pedidosBD = value; }
        }

    }
}