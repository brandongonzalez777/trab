using System;

class Animal
{
    public string Nombre { get; private set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine("Sonido de animal");
    }
}
