using System;
using System.Collections.Generic;

class Program
{
    static List<Animal> animales = new List<Animal>();

    static void Main()
    {
        int opcion;

        do
        {
            MostrarMenu();
            Console.Write("Selecciona una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearPerro();
                    break;
                case 2:
                    CrearGato();
                    break;
                case 3:
                    MostrarAnimales();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Opciones:");
        Console.WriteLine("1. Perro");
        Console.WriteLine("2. Gato");
        Console.WriteLine("3. Mostrar Animales");
        Console.WriteLine("4. Salir");
    }

    static void CrearPerro()
    {
        Console.Write("Ingrese el nombre del perro: ");
        string nombre = Console.ReadLine();
        Perro perro = new Perro(nombre);
        animales.Add(perro);
        Console.WriteLine("Perro creado con éxito.");
        Console.WriteLine("==========================================");
    }

    static void CrearGato()
    {
        Console.Write("Ingrese el nombre del gato: ");
        string nombre = Console.ReadLine();
        Gato gato = new Gato(nombre);
        Console.Write("Ingrese la cantidad de vidas del gato: ");
        int vidas = int.Parse(Console.ReadLine());
        gato.EstablecerVidas(vidas);
        animales.Add(gato);
        Console.WriteLine("Gato creado con éxito.");
        Console.WriteLine("==========================================");
    }

    static void MostrarAnimales()
    {
        if (animales.Count == 0)
        {
            Console.WriteLine("No hay animales para mostrar.");
        }
        else
        {
            Console.WriteLine("Información de los animales:");
            foreach (var animal in animales)
            {
                Console.WriteLine($"Nombre: {animal.Nombre}");
                animal.HacerSonido();
                if (animal is Gato)
                {
                    Gato gato = (Gato)animal;
                    Console.WriteLine($"Vidas: {gato.ObtenerVidas()}");
                }
                Console.WriteLine();
            }
        }
    }
}
