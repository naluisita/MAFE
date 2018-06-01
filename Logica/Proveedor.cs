using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Proveedor
    {
        private string rut;
        private string nombre;
        private string apellido;
        private string telefono;
        private string correo;

        public Proveedor()
        {
            this.rut = " ";
            this.nombre = " ";
            this.apellido = " ";
            this.telefono = " ";
            this.correo = " ";
        }
        private string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
    }
}
