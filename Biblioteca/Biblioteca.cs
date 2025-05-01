using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        public Libro buscarLibro(string titulo)
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

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            if (buscarLibro(titulo) == null)
            {
                libros.Add(new Libro(titulo, autor, editorial));
                return true;
            }
            return false;
        }

        public bool eliminarLibro(string titulo)
        {
            Libro libroAEliminar = buscarLibro(titulo);
            if (libroAEliminar != null)
            {
                libros.Remove(libroAEliminar);
                return true;
            }
            return false;
        }

        public void listarLibros()
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

        public bool altaLector(string nombre, string dni)
        {
            if (buscarLector(dni) == null)
            {
                lectores.Add(new Lector(nombre, dni));
                return true;
            }
            return false;
        }

        public Lector buscarLector(string dni)
        {
            return lectores.Find(l => l.Dni == dni);
        }

        public String prestarLibro(string dni, string titulo)
        {
            Lector lector = buscarLector(dni);
            if (lector == null)
            {
                return "LECTOR INEXISTENTE";
            }

            Libro libro = buscarLibro(titulo);
            if (libro == null)
            {
                return "LIBRO INEXISTENTE";
            }

            if (!lector.puedePedirPrestamo())
            {
                return "TOPE DE PRÉSTAMO ALCANZADO";
            }

            // Se presta el libro
            lector.agregarPrestamo(libro);
            libros.Remove(libro);

            return "PRÉSTAMO EXITOSO";
        }
    }
}
