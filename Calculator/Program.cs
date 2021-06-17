using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Enter 1st number and then press Enter:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number, and then press Enter:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option:");
            Console.WriteLine("a for Add");
            Console.WriteLine("s for Subtract");
            Console.WriteLine("m for Multiply");
            Console.WriteLine("d for Divide");

            Console.Write("Enter an Option: ");

            switch(Console.ReadLine())
            {
                case "a":
                    Console.Write($"Result: { num1}+ {num2} =  " + (num1+num2));
                    Console.WriteLine("\n");
                    break;
                case "s":
                    Console.Write($"Result: { num1} - {num2} =  " + (num1 - num2));
                    Console.WriteLine("\n");

                    break;
                case "m":
                    Console.Write($"Result: { num1} * {num2} =  " + (num1 * num2));
                    Console.WriteLine("\n");

                    break;
                case "d":
                    Console.Write($"Result: { num1} / {num2} =  " + (num1 / num2));
                    Console.WriteLine("\n");

                    break;


            }

            Console.Write("Press any key to close the application");
            Console.ReadKey();



        }
    }
}
