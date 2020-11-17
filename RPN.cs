using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    class Operations
    {
        static public string RPN(string input)
        {
            stack<string> myStack = new stack<string>(10);
            foreach (var i in input.Split(' '))
            {
                try
                {
                    myStack.Push(Convert.ToString(i));
                }
                catch
                {
                    int num2 = Convert.ToInt32(myStack.Pop());
                    int num1 = Convert.ToInt32(myStack.Pop());
                    switch (i)
                    {
                        case "+":
                            myStack.Push(Convert.ToString(num1 + num2));
                            break;
                        case "-":
                            myStack.Push(Convert.ToString(num1 - num2));
                            break;
                        case "/":
                            myStack.Push(Convert.ToString(num1 / num2));
                            break;
                        case "*":
                            myStack.Push(Convert.ToString(num1 * num2));
                            break;
                    }
                }
            }
            return myStack.Pop();

        }
    }
}
