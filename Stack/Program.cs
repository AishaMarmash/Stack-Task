using System;

namespace Stack
{
    class program
    {
        public static void Main()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Print();
            Console.WriteLine(stack.Pop());
            stack.Push(2);
            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Print();
            Console.WriteLine(stack.Pop());
            stack.Clear();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine(stack.Peak());
            Console.WriteLine("============================");
            Console.WriteLine("Stack of integer :");
            stack.Print();

            MyStack<string> stringStack = new MyStack<string>();
            stringStack.Push("Aisha");
            stringStack.Push("Jamal");
            stringStack.Push("pp");
            stringStack.Pop();
            Console.WriteLine("============================");
            Console.WriteLine("Stack of string :");
            stringStack.Print();
        }
    }
}