using System;
using System.Collections.Generic;

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
        public List<Libro> Prestamos => prestamos;

        public bool PuedePedirPrestamo()
        {
            return prestamos.Count < MAX_PRESTAMOS;
        }

        public bool AgregarPrestamo(Libro libro)
        {
            if (PuedePedirPrestamo())
            {
                prestamos.Add(libro);
                return true;
            }
            return false;
        }

        public void MostrarPrestamos()
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
