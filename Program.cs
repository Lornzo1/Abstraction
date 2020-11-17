using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Tester!");
            stack<char> myStack = new stack<char>(10);
            myStack.Push('m');
            myStack.Push('B');
            Console.WriteLine(myStack.Pop());// should return b
            myStack.Push('o');
            myStack.Push('o');
            Console.WriteLine(myStack.Pop());//return o
            Console.WriteLine(myStack.Pop());//o
            Console.WriteLine(myStack.Pop());//m
            Console.WriteLine(myStack.Pop());// underflow
            Console.WriteLine(RPN.Converter("5 4 * 3 2 * + 1 -"));//25
            queue<int> myQueue = new queue<int>(5);
            myQueue.Push(5);
            myQueue.Push(3);
            myQueue.Push(7);
            myQueue.Push(8);
            myQueue.Push(4);
            myQueue.Output();//53784
            Console.WriteLine(myQueue.Dequeue());//5
            myQueue.Push(1);
            myQueue.Push(8);//overflow
            myQueue.Output();//13784
            Console.WriteLine(myQueue.Dequeue());//3
            Console.WriteLine(myQueue.Dequeue());//7
            Console.WriteLine(myQueue.Dequeue());//8
            Console.WriteLine(myQueue.Dequeue());//4
            Console.WriteLine(myQueue.Dequeue());//1
            Console.WriteLine(myQueue.Dequeue());//queue empty
        }
    }
}
