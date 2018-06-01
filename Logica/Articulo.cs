using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Articulo
    {
        private string referencia;
        private string descripcion;
        private double precio;

        public Articulo()
        {
            this.referencia = " ";
            this.descripcion = " ";
            this.precio = 0;
        }
        private string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        private string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
