using System;

public class Perro : Animal
{
    public Perro(string nombre) : base(nombre)
    {
    }

    public override void HacerSonido()
    {
        Console.WriteLine("Woof");
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Perro - Nombre: {Nombre}, Raza: {Raza}");
    }
}