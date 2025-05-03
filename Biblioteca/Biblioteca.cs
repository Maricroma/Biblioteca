using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Biblioteca
    {
        private readonly List<Libro> libros;
        private readonly List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        public Libro BuscarLibro(string titulo)
        {
            foreach (var libro in libros)
            {
                if (libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return libro;
                }
            }
            return null;
        }

        public bool AgregarLibro(string titulo, string autor, string editorial)
        {
            if (BuscarLibro(titulo) == null)
            {
                libros.Add(new Libro(titulo, autor, editorial));
                return true;
            }
            return false;
        }

        public bool EliminarLibro(string titulo)
        {
            Libro libroAEliminar = BuscarLibro(titulo);
            if (libroAEliminar != null)
            {
                libros.Remove(libroAEliminar);
                return true;
            }
            return false;
        }

        public void ListarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca.");
            }
            else
            {
                foreach (var libro in libros)
                {
                    Console.WriteLine(libro);
                }
            }
        }

        public bool AltaLector(string nombre, string dni)
        {
            if (BuscarLector(dni) == null)
            {
                lectores.Add(new Lector(nombre, dni));
                return true;
            }
            return false;
        }

        public Lector BuscarLector(string dni)
        {
            return lectores.Find(l => l.Dni == dni);
        }

        public String PrestarLibro(string dni, string titulo)
        {
            Lector lector = BuscarLector(dni);
            if (lector == null)
            {
                return "LECTOR INEXISTENTE";
            }

            Libro libro = BuscarLibro(titulo);
            if (libro == null)
            {
                return "LIBRO INEXISTENTE";
            }

            if (!lector.PuedePedirPrestamo())
            {
                return "TOPE DE PRÉSTAMO ALCANZADO";
            }

            // Se presta el libro
            lector.AgregarPrestamo(libro);
            libros.Remove(libro);

            return "PRÉSTAMO EXITOSO";
        }
    }
}
