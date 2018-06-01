using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Producto
    {
        private string id_producto;
        private string nombre;
        private double precio;
        private string id_categoria;

        public Producto()
        {
            this.id_producto = " ";
            this.nombre = " ";
            this.precio = 0;
        }
        private string Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        private string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private string Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

    }
}
