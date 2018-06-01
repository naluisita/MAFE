using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Logica
{
    class Compra
    {
        private int referencia;
        private ArrayList productos;

        public Compra()
        {
            this.referencia = 0;
            this.productos = new ArrayList();
        }
        private int Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        private ArrayList Producto
        {
            get { return productos; }
            set { productos = value; }
        }
    }
}
