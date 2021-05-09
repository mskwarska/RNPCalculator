using System;
using System.Collections.Generic;

namespace Convert.Service
{
    static class CalculateService
    {

        public static double CalculateRNP(string infix)
        {
            Stack<double> stack = new Stack<double>();
            
            string postfix;
            ConvertToRNPService.ConvertToRNP(ref infix, out postfix);

            for (int i = 0; i < postfix.Length; i++)
            {
                var symbol = postfix[i];
                double number;
                bool success = Double.TryParse(symbol.ToString(), out number);
                if (success)
                {
                    stack.Push(number);
                }
                else if (symbol == '+')
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                    stack.Push(Addition(second, first));
                }
                else if (symbol.Equals('-'))
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                    stack.Push(Substraction(second, first));
                }
                else if (symbol.Equals('*'))
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                    stack.Push(Multiply(second, first));
                }
                else if (symbol.Equals('/'))
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                    stack.Push(Divide(second, first));
                }

            }
            // here is the result - the last number on the stack
            return stack.Pop();

        }


        public static bool IsEmpty<T>(this Stack<T> stack)
        {
            return (stack.Count == 0);
        }

        public static double Addition(double number1, double number2) => number1 + number2;
        public static double Substraction(double number1, double number2) => number1 - number2;
        public static double Multiply(double number1, double number2) => number1 * number2;
        public static double Divide(double number1, double number2) => number1 / number2;
    }
}
