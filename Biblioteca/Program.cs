using System;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Console.WriteLine("Bienvenido a la biblioteca virtual");

            while (true)
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Listar libros");
                Console.WriteLine("3. Eliminar libro");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarLibro(biblioteca);
                        break;
                    case "2":
                        biblioteca.ListarLibros();
                        break;
                    case "3":
                        EliminarLibro(biblioteca);
                        break;
                    case "4":
                        Console.WriteLine("Gracias por usar la biblioteca virtual. ¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        static void AgregarLibro(Biblioteca biblioteca)
        {
            Console.WriteLine("Ingrese el título del libro:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor del libro:");
            string autor = Console.ReadLine();
            Console.WriteLine("Ingrese la editorial del libro:");
            string editorial = Console.ReadLine();

            if (biblioteca.AgregarLibro(titulo, autor, editorial))
            {
                Console.WriteLine("Libro agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("El libro ya existe en la biblioteca.");
            }
        }

        static void EliminarLibro(Biblioteca biblioteca)
        {
            Console.WriteLine("Ingrese el título del libro a eliminar:");
            string tituloEliminar = Console.ReadLine();

            if (biblioteca.EliminarLibro(tituloEliminar))
            {
                Console.WriteLine("Libro eliminado.");
            }
            else
            {
                Console.WriteLine("El libro no existe en la biblioteca.");
            }
        }
    }
}
