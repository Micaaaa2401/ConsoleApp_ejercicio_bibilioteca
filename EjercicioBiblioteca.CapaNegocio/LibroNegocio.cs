using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ejercicio_bibilioteca.Acceso_a_Datos
{
    internal class LibroNegocio
    {
        private LibroDatos _libroDatos;

        public LibroNegocio()
        {
            _libroDatos = new LibroDatos();
            
        }
        //probando metodo
        public List<Libro> GetListaLibro()
        {
            List<Libro> list = _libroDatos.TraerTodos();

            return list;
        }


    }
}
