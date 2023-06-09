﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ejercicio_bibilioteca
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public Persona (string nombre, string apellido, string direccion)
        {
            nombre = Nombre;
            apellido = Apellido;
            direccion = Direccion;
        }
    }
}
