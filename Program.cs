using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Console.WriteLine("Stack Tester!");
                      stack<char> myStack = new stack<char>(10);
                      myStack.Push('m');
                      myStack.Push('B');
                      Console.WriteLine(myStack.Pop());
                      myStack.Push('o');
                      myStack.Push('o');
                      Console.WriteLine(myStack.Pop());
                      Console.WriteLine(myStack.Pop());
                      Console.WriteLine(myStack.Pop());
                      Console.WriteLine(myStack.Pop());
                      Console.WriteLine(Operator.RPN("5 4 * 3 2 * + 1 -"));*/
            queue<int> myQueue = new queue<int>(5);
            myQueue.Push(5);
            myQueue.Push(3);
            myQueue.Push(7);
            myQueue.Push(8);
            myQueue.Push(4);
            myQueue.Output();
            Console.WriteLine(myQueue.Dequeue());
            myQueue.Push(1);
            myQueue.Push(8);
            myQueue.Output();
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
        }
    }
}
