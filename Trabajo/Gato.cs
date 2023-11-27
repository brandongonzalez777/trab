using System;

public class Gato : Animal
{
    private int Vidas { get; set; }

    public Gato(string nombre) : base(nombre)
    {
    }

    public void EstablecerVidas(int vidas)
    {
        Vidas = vidas;
    }

    public int ObtenerVidas()
    {
        return Vidas;
    }

    public override void HacerSonido()
    {
        Console.WriteLine("Meow");
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Gato - Nombre: {Nombre}, Raza: {Raza}, Vidas: {Vidas}");
    }
}