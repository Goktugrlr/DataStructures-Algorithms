using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an int queue
        Queue<int> intQueue = new Queue<int>();

        intQueue.Enqueue(10);
        intQueue.Enqueue(20);
        intQueue.Enqueue(30);
        intQueue.Enqueue(40);

        Console.WriteLine("int queue contents (FIFO):");
        intQueue.PrintQueue();

        Console.WriteLine("\nPeek: " + intQueue.Peek());
        Console.WriteLine("Dequeued: " + intQueue.Dequeue());

        Console.WriteLine("\nQueue after dequeue:");
        intQueue.PrintQueue();

        Console.WriteLine("\nElement count in the queue: " + intQueue.Count());

        intQueue.Enqueue(32);
        intQueue.Enqueue(96);
        intQueue.Enqueue(64);
        intQueue.Enqueue(128);

        Console.WriteLine("\nQueue after enqueues:");
        intQueue.PrintQueue();

        intQueue.Clear();
        Console.WriteLine("\nQueue after Clear method:");
        intQueue.PrintQueue();

        Console.WriteLine();

        // Create a string queue
        Queue<string> strQueue = new Queue<string>();

        strQueue.Enqueue("ABC");
        strQueue.Enqueue("DEF");
        strQueue.Enqueue("GHI");

        strQueue.Dequeue();

        Console.WriteLine("string queue contents (FIFO):");
        strQueue.PrintQueue();
    }
}

