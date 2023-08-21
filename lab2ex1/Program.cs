using System;

namespace lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
citit de la tastatura.
            */

            Console.WriteLine("Introduceti n!");
            var numar = int.Parse(Console.ReadLine());
            int suma = 0 ;

            while (numar != 0)
            {
                int ultimaCifra = numar % 10;
                suma += ultimaCifra;
                numar /= 10;
            }
            Console.WriteLine("Suma cifrelor este:" + suma);
        }
    }
}
