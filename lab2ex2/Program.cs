using System;

namespace lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex2
             Scrieti un program care va afisa factorialul unui numar n, n fiind citit
            de la tastatura*/
            Console.WriteLine("Introduceti n!");
            int numar = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= numar; i++)
            {
                factorial *= i; //factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
