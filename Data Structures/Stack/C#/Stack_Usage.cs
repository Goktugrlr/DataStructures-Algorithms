using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an int stack
        Stack<int> intStack = new();

        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        intStack.Push(40);

        Console.WriteLine("int stack contents (LIFO):");
        intStack.PrintStack();

        Console.WriteLine("\nPeek: " + intStack.Peek()); 
        Console.WriteLine("Popped: " + intStack.Pop());       

        Console.WriteLine("\nStack after pop:");
        intStack.PrintStack();

        Console.WriteLine("\nElement count in the stack: " + intStack.Count());

        intStack.Push(32);
        intStack.Push(96);
        intStack.Push(64);
        intStack.Push(128);

        Console.WriteLine("\nStack after pushes:");
        intStack.PrintStack();

        Console.WriteLine();

        // Create a string stack
        Stack<string> strStack = new Stack<string>();

        strStack.Push("ABC");
        strStack.Push("DEF");
        strStack.Push("GHI");

        strStack.Pop();

        Console.WriteLine("string stack contents (LIFO):");
        strStack.PrintStack();
    }
}
