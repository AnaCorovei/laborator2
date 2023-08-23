using System;

namespace lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Scrieti un program care va determina daca un numar este sau nu palindrom
             */
            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());
            int dubluraNumar = numar, palindrom = 0;
            while (dubluraNumar !=0 )
            {
                palindrom = (palindrom * 10) + (dubluraNumar % 10);
                dubluraNumar = dubluraNumar / 10;
            }
            if (numar == palindrom)
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom");
            }


        }
    }
}
