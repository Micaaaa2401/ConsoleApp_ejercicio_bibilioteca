using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ejercicio_bibilioteca
{
    public class Prestamo
    {
        private int _idPrestamo;
        private DateTime _fechaInicio;
        private DateTime _fechaDevolucion;
        private Boolean _estado;
        private Ejemplar _ejemplarPrestado;
        private int _idCliente;

        public int IdPrestamo
        {
            get { return _idPrestamo; }
            set { _idPrestamo = value; }
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime FechaDevolucion
        {
            get { return _fechaDevolucion; }
            set { _fechaDevolucion = value; }
        }

        public Boolean Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public Ejemplar EjemplarPrestado
        {
            get { return _ejemplarPrestado; }
            set { _ejemplarPrestado = value; }
        }

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public Prestamo(int idPrestamo, DateTime fechaInicio, DateTime fechaDevolucion,
            Boolean estado, Ejemplar ejemplarPrestado, int idCliente)
        {
            idPrestamo = IdPrestamo;
            fechaInicio = FechaInicio;
            fechaDevolucion = FechaDevolucion;
            estado = Estado;
            ejemplarPrestado = EjemplarPrestado;
            idCliente = IdCliente;

        }
    }
}
