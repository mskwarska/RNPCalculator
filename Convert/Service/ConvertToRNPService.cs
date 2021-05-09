using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert.Service
{
    class ConvertToRNPService
    {
        public string ConvertToRNP(ref string infix, out string postfix)
        {

            int prio = 0;
            postfix = "";
            Stack<Char> stackRNP = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                char ch = infix[i];
                if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
                {
                    if (stackRNP.Count <= 0)
                        stackRNP.Push(ch);
                    else
                    {
                        if (stackRNP.Peek() == '*' || stackRNP.Peek() == '/')
                            prio = 1;
                        else
                            prio = 0;
                        if (prio == 1)
                        {
                            if (ch == '+' || ch == '-')
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
                            if (ch == '+' || ch == '-')
                            {
                                postfix += stackRNP.Pop();
                                stackRNP.Push(ch);

                            }
                            else
                                stackRNP.Push(ch);
                        }
                    }
                }
                else
                {
                    postfix += ch;
                }
            }
            int len = stackRNP.Count;
            for (int j = 0; j < len; j++)
                postfix += stackRNP.Pop();
            return postfix;
        }

    }
}
