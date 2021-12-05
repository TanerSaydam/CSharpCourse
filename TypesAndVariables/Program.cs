using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            //Commend Line // Yorum Satırı
            
            double number5 = 10.4;
            decimal number6 = 10;
            char character = 'A';
            bool condition = true;
            byte number4 = 0;
            //byte number4 = 255;
            short number3 = 32767;
            int number1 = -2147483647;
            //int number1 = 2147483647;
            long number2 = -9223372036854775808;
            //long number2 = 9223372036854775808;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number3 is {0}",number3);
            Console.WriteLine("Number4 is {0}",number4);
            Console.WriteLine("Number5 is {0}",number5);
            Console.WriteLine("Number7 is {0}",number7);
            Console.WriteLine("Chracter is : {0}", (int)character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=10,
        Tuesday=20,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
