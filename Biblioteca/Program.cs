using System;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            cargarLibros(10);
            cargarLibros(2);
            biblioteca.listarLibros();
            biblioteca.eliminarLibro("El Principito");
            biblioteca.listarLibros();

            void cargarLibros(int cantidad)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Ingrese el título del libro:");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Ingrese el autor del libro:");
                    string autor = Console.ReadLine();
                    Console.WriteLine("Ingrese la editorial del libro:");
                    string editorial = Console.ReadLine();
                    if (biblioteca.agregarLibro(titulo, autor, editorial))
                    {
                        Console.WriteLine("Libro agregado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("El libro ya existe en la biblioteca.");
                    }
                }
            }
        }
    }
}
