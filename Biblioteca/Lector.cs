using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Lector
    {
        public string Nombre { get; }
        public string Dni { get; }
        private List<Libro> prestamos;

        public Lector(string nombre, string dni)
        {
            Nombre = nombre;
            Dni = dni;
            prestamos = new List<Libro>();
        }

        public bool puedePedirPrestamo()
        {
            return prestamos.Count < 3;
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
