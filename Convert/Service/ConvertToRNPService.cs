using System;
using System.Collections.Generic;

namespace Convert.Service
{
    class ConvertToRNPService
    {
        public static string ConvertToRNP(ref string infix, out string postfix)
        {
            // Infix is an equation which user enter
            //To check my converter I use  online converter like https://scanftree.com/Data_Structure/prefix-postfix-infix-online-converter
            int priority = 0;
            postfix = "";
            Stack<Char> stackRNP = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                char singleChar = infix[i];
                if (singleChar == '+' || singleChar == '-' || singleChar == '*' || singleChar == '/')
                {
                    if (stackRNP.Count <= 0)
                        stackRNP.Push(singleChar);
                    else
                    {
                        if (stackRNP.Peek() == '*' || stackRNP.Peek() == '/')
                            priority = 1;
                        else
                            priority = 0;
                        if (priority == 1)
                        {
                            if (singleChar == '+' || singleChar == '-')
                            {
                                postfix += stackRNP.Pop();
                                i--;
                            }
                            else
                            {
                                postfix += stackRNP.Pop();
                                i--;
                            }
                        }
                        else
                        {
                            if (singleChar == '+' || singleChar == '-')
                            {
                                postfix += stackRNP.Pop();
                                stackRNP.Push(singleChar);

                            }
                            else
                                stackRNP.Push(singleChar);
                        }
                    }
                }
                else
                {
                    postfix += singleChar;
                }
            }
            int stackLength = stackRNP.Count;
            for (int j = 0; j < stackLength; j++)
                postfix += stackRNP.Pop();
            return postfix;
        }

    }
}
