using System;

class Gato : Animal
{
    private int vidas;

    public Gato(string nombre) : base(nombre)
    {
    }

    public void EstablecerVidas(int vidas)
    {
        this.vidas = vidas;
    }

    public int ObtenerVidas()
    {
        return vidas;
    }

    public override void HacerSonido()
    {
        Console.WriteLine("Meow");
    }
}
