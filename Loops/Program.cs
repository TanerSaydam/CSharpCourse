using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //For();
            //ForEach();
            int sayi = 7;
            Console.WriteLine(IsPrimeNumber(sayi) ? "This is a prime number" : "This is not a prime number");

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number%i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static void ForEach()
        {
            string[] students = new string[3] { "Engin", "Derin", " Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void For()
        {
            for (int i = 100; i >= 1; i -= 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");
        }
    }
}
