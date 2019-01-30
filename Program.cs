using Kafic_vjezbaa1.Sastojci;
using System;

namespace Kafic_vjezbaa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Koktel CubaLibre = new Koktel("Cuba Libre");
            CubaLibre.Dodaj(new Limeta(0.5));
            CubaLibre.Dodaj(new Rum(0.4, "Bacardi Gold"));
            CubaLibre.Dodaj(new CocaCola(1, "zero"));
            CubaLibre.Dodaj(new Led("zdrobljeni"));
            Console.Write(CubaLibre.Posluzi());
        }
    }
}
