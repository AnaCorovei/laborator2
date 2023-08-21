using System;

namespace lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 3 Să se scrie un program care citeşte de la tastatură un şir de n numere 
             naturale şi determină media aritmetică a celor pare, n fiind citit de la 
             tastatra
            */

            Console.WriteLine("Introduceti numarul de cifre din sir!");
            int numar = int.Parse(Console.ReadLine());
            int suma = 0;
            int numerePare = 0;
            for (int i = 1; i<=numar; i ++)
            {
                int numarCurent = int.Parse(Console.ReadLine());
                if (numarCurent % 2 == 0)
                {
                    numerePare++;
                    suma = suma + numarCurent;
                }
                if (numerePare == 0)
                {
                    numerePare++;
                }
                suma = suma / numerePare;
                Console.WriteLine(suma);
            }

        }
    }
}
