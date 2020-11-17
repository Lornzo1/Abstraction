using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    static class RPN
    {
        static public int Converter(string input)
        {
            stack<int> myStack = new stack<int>(10);
            foreach ( string i in input.Split(' '))
            {
                try
                {
                    myStack.Push(Convert.ToInt32(i));
                }
                catch
                {
                    int num2 = Convert.ToInt32(myStack.Pop());
                    int num1 = Convert.ToInt32(myStack.Pop());
                    switch (i)
                    {
                        case "+":
                            myStack.Push(num1 + num2);
                            break;
                        case "-":
                            myStack.Push(num1 - num2);
                            break;
                        case "/":
                            myStack.Push(num1 / num2);
                            break;
                        case "*":
                            myStack.Push(num1 * num2);
                            break;
                    }
                }
            }
            return myStack.Pop();

        }
    }
}
