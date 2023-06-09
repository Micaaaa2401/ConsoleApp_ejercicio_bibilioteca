﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ejercicio_bibilioteca
{
    public class Ejemplar
    {
        private int _idLibro;
        private int _id;
        private string _observaciones;
        private int _precio;
        private DateTime _fechaAlta;
        private bool _prestado;


        public int IdLibro
        {
            get { return _idLibro; }
            set { _idLibro = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        public DateTime FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }
        
        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public bool Prestado
        {
            get { return _prestado; }
            set { _prestado = value; }
        }

        public Ejemplar(int idLibro, int id , string observaciones, DateTime fechaAlta, int precio ) 
        {
            IdLibro = idLibro;
            Id = id;
            Observaciones = observaciones;
            FechaAlta = fechaAlta;
            Precio = precio;
        }

        

    }
}
