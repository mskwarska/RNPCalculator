using Convert.Service;
using System;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEquation();

            EnterEquation();

            Console.ReadLine();
        }

        public static void TestEquation()
        {
            Console.WriteLine("4+5*2");
            Console.WriteLine("The result of the equation is: " + CalculateService.CalculateRNP("4+5*2"));
            Console.WriteLine();

            Console.WriteLine("4+5/2");
            Console.WriteLine("The result of the equation is: " + CalculateService.CalculateRNP("4+5/2"));
            Console.WriteLine();

            Console.WriteLine("4+5/2-1");
            Console.WriteLine("The result of the equation is: " + CalculateService.CalculateRNP("4+5/2-1"));
            Console.WriteLine();

        }

        public static void EnterEquation()
        {
            Console.WriteLine("Enter your equation:");
            string equation = Console.ReadLine();
            Console.WriteLine("The result of the equation is: " + CalculateService.CalculateRNP(equation));
            Console.WriteLine();
        }

    }
}
