using System;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            //cargarLibros(10);
            biblioteca.AgregarLibro("El Principito", "Antoine de Saint-Exupéry", "Reynal & Hitchcock");
            biblioteca.AgregarLibro("Cien años de soledad", "Gabriel García Márquez", "Editorial Sudamericana");
            biblioteca.AgregarLibro("1984", "George Orwell", "Secker & Warburg");
            biblioteca.AgregarLibro("El túnel", "Ernesto Sabato", "Editorial Sudamericana");
            biblioteca.AgregarLibro("Rayuela", "Julio Cortázar", "Editorial Sudamericana");
            biblioteca.AgregarLibro("El Aleph", "Jorge Luis Borges", "Editorial Losada");
            biblioteca.ListarLibros();
            //biblioteca.eliminarLibro("El Principito");
            //biblioteca.listarLibros();

            biblioteca.AltaLector("Juan Pérez", "12345678");
            Console.WriteLine(biblioteca.PrestarLibro("1234567", "El Principito"));
            Console.WriteLine(biblioteca.PrestarLibro("12345678", "Odisea"));
            Console.WriteLine(biblioteca.PrestarLibro("12345678", "El Principito"));
            biblioteca.ListarLibros();

            //void cargarLibros(int cantidad)
            //{
            //    for (int i = 0; i < cantidad; i++)
            //    {
            //        Console.WriteLine("Ingrese el título del libro:");
            //        string titulo = Console.ReadLine();
            //        Console.WriteLine("Ingrese el autor del libro:");
            //        string autor = Console.ReadLine();
            //        Console.WriteLine("Ingrese la editorial del libro:");
            //        string editorial = Console.ReadLine();
            //        if (biblioteca.agregarLibro(titulo, autor, editorial))
            //        {
            //            Console.WriteLine("Libro agregado exitosamente.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("El libro ya existe en la biblioteca.");
            //        }
            //    }
            //}
        }
    }
}
