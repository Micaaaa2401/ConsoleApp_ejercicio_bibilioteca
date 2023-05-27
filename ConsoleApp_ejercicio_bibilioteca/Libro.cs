using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ejercicio_bibilioteca
{
    public class Libro
    {
        private int _idLibro;
        private string _titulo;
        private string _autor;
        private DateTime _fechaPublicacion;
        private string _editorial;
        private List<Ejemplar> _ejemplares;

        public int IdLibro
        {
            get { return _idLibro; }
            set { _idLibro = value; }
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public DateTime FechaPublicacion
        {
            get { return _fechaPublicacion; }
            set { _fechaPublicacion = value; }
        }

        public string Editorial
        {
            get { return _editorial; }
            set { _editorial = value; }
        }

        public List<Ejemplar> Ejemplares
        {
            get { return _ejemplares; }
            set { _ejemplares= value; }
        }

        public Libro(int idLibro, string titulo, string autor, DateTime fechaPublicacion,
            string editorial)
        {
            idLibro = IdLibro;
            Titulo = titulo;
            Autor = autor;
            FechaPublicacion = fechaPublicacion;
            Editorial = editorial;
            Ejemplares = new List<Ejemplar>();

        }
    }
}
