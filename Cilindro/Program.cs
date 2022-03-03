using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double a; 
            double r; 
            double Volume;
            double AreaSup;

            double pi = Math.PI;



            Console.WriteLine("Altura Cilindro: ");
            a = double.Parse( Console.ReadLine());
            Console.WriteLine("Raio Cilindro: ");
            r = double.Parse(Console.ReadLine());

            Volume = pi * Math.Pow(r,2) * a;  
            AreaSup = 2 * pi * r * (r + a);

            Console.WriteLine($"Volume do seu cilindro é igual a: {Volume}");
            Console.WriteLine($"A Área de superfície do seu cilindro é igual a: {AreaSup}");
        }
    }
}
