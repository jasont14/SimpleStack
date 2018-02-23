using System;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simplified stack class.\n");

            StackExample myStack = new StackExample(3);

            Console.WriteLine("Push 'First'");
            myStack.Push("First");

            Console.WriteLine("Push 'Second'");
            myStack.Push("Second");

            Console.WriteLine("Push 3");
            myStack.Push(3);

            Console.WriteLine("\nPush added, now Pop will remove Last in First Out 'LIFO'.\n");

            Console.WriteLine("Pop (LIFO), should be '3': {0}", myStack.Pop());            
            Console.WriteLine("Pop (LIFO), should be 'Second': {0}",myStack.Pop());            
            Console.WriteLine("Pop (LIFO), should be 'First': {0}" ,myStack.Pop());
            Console.ReadLine();
        }
    }

    public class StackExample
    {

        private object[] items;
        private int stackPointer = 0;
        
        public StackExample(int size)
        {
            items = new object[size];
        }

        public object Pop()
        {
            return items[--stackPointer];  //note '--' is a prefix decrement and evaluates 'stackPointer' after it has been reduced by 1.
        }

        public void Push(object obj)
        {
            items[stackPointer] = obj;
            stackPointer++;
        }
    }
}
