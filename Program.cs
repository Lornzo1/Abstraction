using System;

namespace Stacks
{
    class stack
    {
        public char[] new_stack;
        public int stack_pointer = -1;
        public stack(int s)
        {
            new_stack = new char[s];
        }
        public char[] Push(char ToBe)
        {
            if (new_stack.Length > stack_pointer)
            {
                new_stack[stack_pointer+1] = ToBe;
                stack_pointer += 1;
            }
            else Console.WriteLine("overflow");
            return new_stack;
        }
        public char Pop()
        {
            char a = ' '; 
            if (stack_pointer != -1)
            {
                a = new_stack[stack_pointer];
                new_stack[stack_pointer] = ' ';
                stack_pointer -= 1;
            }
            else Console.WriteLine("underflow");
            return a;
        }
        public int Operator(string input)
        {
            foreach (var i in (input.Split(' ')))
            {

                try
                {
                    Push(Convert.ToChar(Convert.ToInt32(i)));
                }
                catch
                {
                    int num2 = Convert.ToInt32(Pop());
                    int num1 = Convert.ToInt32(Pop());
                    switch (i)
                    {
                        case "+":
                            Push(Convert.ToChar(num1 + num2));
                            break;
                        case "-":
                            Push(Convert.ToChar(num1 - num2));
                            break;
                        case "/":
                            Push(Convert.ToChar(num1 / num2));
                            break;
                        case "*":
                            Push(Convert.ToChar(num1 * num2));
                            break;
                    }
                }
            }
            return Pop();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Tester!");
            stack myStack = new stack(10);
            myStack.Push('m');
            myStack.Push('B');
            Console.WriteLine(myStack.Pop());
            myStack.Push('o');
            myStack.Push('o');
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Operator("5 4 * 3 2 * + 1 -"));
        }
    }
}
