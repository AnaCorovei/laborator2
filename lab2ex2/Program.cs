using System;

namespace lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
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
