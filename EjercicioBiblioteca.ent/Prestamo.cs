﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ejercicio_bibilioteca
{
    public class Prestamo
    {
        private int _idCliente;
        private int _idEjemplar;
        private int _plazo;
        private bool _abierto;
        private DateTime _fechaPrestamo;
        private DateTime _fechaDevolucionTentativa;
        private DateTime _fechaDevolucionReal;
        private int _id;

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public int IdEjemplar
        {
            get { return _idEjemplar; }
            set { _idEjemplar = value; }
        }

        public int Plazo
        {
            get { return _plazo; }
            set { _plazo = value; }
        }


        public bool Abierto
        {
            get { return _abierto; }
            set { _abierto = value; }
        }

        public DateTime FechaPrestamo
        {
            get { return _fechaPrestamo; }
            set { _fechaPrestamo = value; }
        }

        public DateTime FechaDevolucionTentativa
        {
            get { return _fechaDevolucionTentativa; }
            set { _fechaDevolucionTentativa = value; }
        }
        public DateTime FechaDevolucionReal
        {
            get { return _fechaDevolucionReal; }
            set { _fechaDevolucionReal = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Prestamo(int idCliente, int idEjemplar, int plazo,
                    DateTime fechaPrestamo, DateTime fechaDevolucionTentativa, DateTime fechaDevolucionReal, int id)
        {
            IdCliente = idCliente;
            IdEjemplar = idEjemplar;
            Plazo = plazo;
            Abierto = true;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucionTentativa = fechaDevolucionTentativa;
            FechaDevolucionReal = fechaDevolucionReal;
            Id = id;

        }
    }
}
