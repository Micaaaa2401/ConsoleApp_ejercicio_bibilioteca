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
        public int _edicion;
        public int _paginas;
        public string _tema;
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

        public int Paginas
        {
            get { return _paginas;}
            set { _paginas = value; }
        }

        public int Edicion
        {
            get { return _edicion;}
            set { _edicion = value; }
        }

        public string Tema
        {
            get { return _tema; }
            set { _tema = value; }
        }
        public List<Ejemplar> Ejemplares
        {
            get { return _ejemplares; }
            set { _ejemplares= value; }
        }


        public Libro(int idLibro, string titulo, string autor, DateTime fechaPublicacion,
            string editorial, int paginas, int edicion, string tema)
        {
            idLibro = IdLibro;
            Titulo = titulo;
            Autor = autor;
            FechaPublicacion = fechaPublicacion;
            Editorial = editorial;
            Ejemplares = new List<Ejemplar>();
            Tema = tema;
            Edicion = edicion;
            Paginas = paginas;

        }


        //pendiente hacer los metodos
    }
}
