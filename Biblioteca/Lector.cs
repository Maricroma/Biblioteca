using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Biblioteca
{
    public class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> prestamos;
        private const int MAX_PRESTAMOS = 3;

        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            prestamos = new List<Libro>();
        }

        public string Dni => dni;
        public string Nombre => nombre;

        public bool puedePedirPrestamo()
        {
            return prestamos.Count < MAX_PRESTAMOS;
        }

        public bool agregarPrestamo(Libro libro)
        {
            if (puedePedirPrestamo())
            {
                prestamos.Add(libro);
                return true;
            }
            return false;
        }

        public void mostrarPrestamos()
        {
            Console.WriteLine($"Préstamos de {Nombre}:");
            if (prestamos.Count == 0)
            {
                Console.WriteLine("  No tiene libros en préstamo.");
            }
            else
            {
                foreach (var libro in prestamos)
                {
                    Console.WriteLine($"  {libro}");
                }
            }
        }
    }
}
