using System;
using System.Collections.Generic;

namespace Convert.Service
{
    static class CalculateService
    {

        public static double CalculateRNP(string infix)
        {
            Stack<int> stack = new Stack<int>();
            
            string postfix;
            ConvertToRNPService.ConvertToRNP(ref infix, out postfix);

            for (int i = 0; i < postfix.Length; i++)
            {
                var symbol = postfix[i];
                int number;
                bool success = Int32.TryParse(symbol.ToString(), out number);
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

        public static int Addition(int number1, int number2) => number1 + number2;
        public static int Substraction(int number1, int number2) => number1 - number2;
        public static int Multiply(int number1, int number2) => number1 * number2;
        public static int Divide(int number1, int number2) => number1 / number2;
    }
}
