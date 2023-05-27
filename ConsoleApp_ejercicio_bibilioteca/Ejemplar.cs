using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ejercicio_bibilioteca
{
    public class Ejemplar
    {
        private int _idEjemplar;
        private Boolean _estadoDisponibilidad;

        public int IdEjemlar
        {
            get { return _idEjemplar; }
            set { _idEjemplar = value; }
        }

        public Boolean EstadoDisponibilidad
        {
            get { return _estadoDisponibilidad; }
            set { _estadoDisponibilidad = value; }
        }

        public Ejemplar(int idEjemplar, Boolean estadoDisponibilidad)
        {
            idEjemplar = IdEjemlar;
            EstadoDisponibilidad = estadoDisponibilidad;
        }

    }
}
