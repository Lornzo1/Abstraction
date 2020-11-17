using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    
    class stack<T>
    {
        private T[] new_stack;
        private int stack_pointer = -1;
        public stack(int s)
        {
            new_stack = new T[s];
        }
        public T[] Push(T ToBe)
        {
            if (new_stack.Length > stack_pointer)
            {
                new_stack[stack_pointer + 1] = ToBe;
                stack_pointer += 1;
            }
            else Console.WriteLine("overflow");
            return new_stack;
        }
        public dynamic Pop()
        {
            T a = default;
            if (stack_pointer != -1)
            {
                a = new_stack[stack_pointer];
                new_stack[stack_pointer] = default;
                stack_pointer -= 1;
            }
            else return "underflow";
            return a;
        }
    }
}
