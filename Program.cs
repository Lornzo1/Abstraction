using System;
using System.Collections.Generic;
using System.Linq;
namespace Stacks
{
    //this is my fist time using classes so apologies it it is not refined however I thought I would give it a go
    class stack
    {
        public List<char> new_stack = new List<char>();
        public int stack_pointer = -1;
        public List<char> Push(char ToBe)
        {
            new_stack.Add(ToBe);
            stack_pointer += 1;
            return new_stack;
        }
        public char Pop()
        {
            char a = ' ';
            if (new_stack.Any())
            {
                a = new_stack[new_stack.Count - 1];
                new_stack.RemoveAt(new_stack.Count - 1);
            }
            
            else Console.WriteLine("underflow");
            return a;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Tester!");
            stack myStack = new stack();
            myStack.Push('m');
            myStack.Push('B');
            Console.WriteLine(string.Join(",",(myStack.Pop())));
            myStack.Push('o');
            myStack.Push('o');
            Console.WriteLine(string.Join(",",(myStack.Pop())));
            Console.WriteLine(string.Join(",", (myStack.Pop())));
            Console.WriteLine(string.Join(",", (myStack.Pop())));
            Console.WriteLine(string.Join(",", (myStack.Pop())));
        }
    }
}
