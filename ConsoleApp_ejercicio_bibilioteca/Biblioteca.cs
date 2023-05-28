using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ejercicio_bibilioteca
{
    public class Biblioteca
    {
        private string _nombre;
        private string _direccion;
        private List<Libro> _libros;
        private List<Cliente> _clientes;
        private List<Prestamo> _prestamos;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Direccion { get { return _direccion; }
            set { _direccion = value; }
        }

        public List<Libro> Libros
        {
            get { return _libros; }
            set { _libros = value; }
        }

        public List<Cliente> Clientes
        {
            get { return _clientes; }
            set { _clientes = value; }
        }

        public List<Prestamo> Prestamos
        {
            get { return _prestamos; }
            set { _prestamos = value; }
        }

        public Biblioteca(string nombre, string direccion)
        {
            nombre = Nombre;
            direccion = Direccion;
            Libros = new List<Libro>();
            Prestamos = new List<Prestamo>();
            Clientes = new List<Cliente>();
        }

        public void IngresarCliente(Cliente cliente)
        {
            this.Clientes.Add(cliente);
        }

       
        public Cliente  ConsultarCliente(int id)  //revisar
        {
            Cliente a = null;

            foreach (Cliente cliente in  this.Clientes)
            {
                if (cliente.IdCliente == id)
                {
                    a = cliente;
                }
            }
            return a;
        }

        public List<Cliente> ListarClientes()
        {
            return this.Clientes;
        }

        public void EliminarCliente(int codigo)
        {
            foreach(Cliente c in this.Clientes)
            {
                if(c.IdCliente==codigo)
                {
                    this.Clientes.Remove(c);
                }
            }
        }
        
        public void AgregarLibro(Libro libro)
        {
            this.Libros.Add(libro);
        }

         public Libro  ConsultarLibro(int id)  //revisar
        {
            Libro a = null;

            foreach (Libro libro in  this.Libros)
            {
                if (libro.IdLibro == id)
                {
                    a = libro;
                }
            }
            return a;
        }
         public List<Libro> ListarLibros()
        {
            return this.Libros;
        }
        
        
    }
}
