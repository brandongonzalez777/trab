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
            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Gato");
            Console.WriteLine("3. Mostrar Animales");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

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
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }

    static void CrearPerro()
    {
        Console.Write("Ingrese el nombre del perro: ");
        string nombre = Console.ReadLine();

        Perro perro = new Perro(nombre);
        animales.Add(perro);

        Console.WriteLine($"Perro '{nombre}' creado exitosamente.");
        Console.WriteLine("========================================");
    }

    static void CrearGato()
    {
        Console.Write("Ingrese el nombre del gato: ");
        string nombre = Console.ReadLine();

        Gato gato = new Gato(nombre);
        Console.Write("Ingrese las vidas del gato: ");
        int vidas = Convert.ToInt32(Console.ReadLine());
        gato.EstablecerVidas(vidas);

        animales.Add(gato);

        Console.WriteLine($"Gato '{nombre}' creado exitosamente con {vidas} vidas.");
        Console.WriteLine("=====================================================");
    }

    static void MostrarAnimales()
    {
        Console.WriteLine("Lista de animales:");

        foreach (var animal in animales)
        {
            animal.MostrarInformacion();
            animal.HacerSonido();
            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
}