using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace Logica
{
    public class Empleado
    {
        private string id_empleado;
        private string nombre;
        private string apellido;
        private string telefono;
        private string username;
        private string contrasena;
        private string correo;
        private string cargo;

        public Empleado()
        {
            this.id_empleado = " ";
            this.nombre = " ";
            this.apellido = " ";
            this.telefono = " ";
            this.username = " ";
            this.contrasena = " ";
            this.correo = " ";
            this.cargo = " ";
        }
        private string Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = value; }
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
        private string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        private string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
    }
}
