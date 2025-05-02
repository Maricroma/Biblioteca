using System;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            //cargarLibros(10);
            biblioteca.agregarLibro("El Principito", "Antoine de Saint-Exupéry", "Reynal & Hitchcock");
            biblioteca.agregarLibro("Cien años de soledad", "Gabriel García Márquez", "Editorial Sudamericana");
            biblioteca.agregarLibro("1984", "George Orwell", "Secker & Warburg");
            biblioteca.agregarLibro("El túnel", "Ernesto Sabato", "Editorial Sudamericana");
            biblioteca.agregarLibro("Rayuela", "Julio Cortázar", "Editorial Sudamericana");
            biblioteca.agregarLibro("El Aleph", "Jorge Luis Borges", "Editorial Losada");
            biblioteca.listarLibros();
            //biblioteca.eliminarLibro("El Principito");
            //biblioteca.listarLibros();

            biblioteca.altaLector("Juan Pérez", "12345678");
            Console.WriteLine(biblioteca.prestarLibro("1234567", "El Principito"));
            Console.WriteLine(biblioteca.prestarLibro("12345678", "Odisea"));
            Console.WriteLine(biblioteca.prestarLibro("12345678", "El Principito"));
            biblioteca.listarLibros();

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
