using System;
using System.Collections.Generic;
using Convert.Service;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Check my converter */
            /*
            ConvertToRNPService convertToRNPService = new ConvertToRNPService();
            Console.WriteLine("The calculator supports operators: +, -, *, / ");
            string infix = "";
            string postfix = "";
            if (args.Length == 1)
            {
                infix = args[0];
                convertToRNPService.ConvertToRNP(ref infix, out postfix);
                System.Console.WriteLine("InFix  :\t" + infix);
                System.Console.WriteLine("PostFix:\t" + postfix);
            }
            else
            {
                infix = "4+5*2";
                convertToRNPService.ConvertToRNP(ref infix, out postfix);
                System.Console.WriteLine("InFix   :\t" + infix);
                System.Console.WriteLine("PostFix :\t" + postfix);
                System.Console.WriteLine();
                infix = "4+5/2";
                convertToRNPService.ConvertToRNP(ref infix, out postfix);
                System.Console.WriteLine("InFix   :\t" + infix);
                System.Console.WriteLine("PostFix :\t" + postfix);
                System.Console.WriteLine();
                infix = "4+5/2-1";
                convertToRNPService.ConvertToRNP(ref infix, out postfix);
                System.Console.WriteLine("InFix   :\t" + infix);
                System.Console.WriteLine("PostFix :\t" + postfix);
                System.Console.WriteLine();
                infix = "a-b/c*d-e--f/h*i++j-/k";
                convertToRNPService.ConvertToRNP(ref infix, out postfix);
                System.Console.WriteLine("InFix   :\t" + infix);
                System.Console.WriteLine("PostFix :\t" + postfix);
                System.Console.WriteLine();
                Console.ReadLine();
            }
            */

            Console.WriteLine("4+5*2");
            Console.WriteLine("The result of the equation is: " + CalculateService.CalculateRNP("4+5*2"));
            Console.WriteLine();

            Console.WriteLine("4+5/2");
            Console.WriteLine("The result of the equation is: " + CalculateService.CalculateRNP("4+5/2"));
            Console.WriteLine();

            Console.WriteLine("4+5/2-1");
            Console.WriteLine("The result of the equation is: " + CalculateService.CalculateRNP("4+5/2-1"));

            Console.ReadLine();
        }
        

    }
}
