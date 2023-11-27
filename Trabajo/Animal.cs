using System;

public abstract class Animal
{
    public string Nombre { get; set; }
    protected string Raza { get; set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public abstract void HacerSonido();
    public abstract void MostrarInformacion();
}