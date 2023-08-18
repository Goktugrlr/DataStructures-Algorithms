using System;
using System.Collections;
using System.Collections.Generic;

public class Queue<T>
{
    private const int DEFAULT_SIZE = 50;
    private T[] queueArray;
    private int front, rear;
    private int count;

    public Queue(int initialSize = DEFAULT_SIZE)
    {
        queueArray = new T[initialSize];

        // rear and front variables represent their index
        rear = -1;
        front = 0;
        // count variable represents the element count in the array
        count = 0;
    }

    // Enqueue method for adding an element to the rear of a queue (FIFO)
    public void Enqueue(T element)
    {
        if (IsFull())
        {
            Extend();
        }

        rear++;
        queueArray[rear] = element;

        count++;
    }

    // Dequeue method for removing an element from the front of a queue (FIFO)
    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty. Dequeue cannot performed.");
        }

        T item = queueArray[front];
        queueArray[front] = default; // Sets the value at the front of the queue to the default value of the type T
        front++;
        count--;

        // Checking if the queue has become significantly smaller (25% of its capacity) compared to its length
        if (count == queueArray.Length / 4)
        {
            Shrink();
        }

        return item;
    }

    // Peek method for getting value of the front element
    public T Peek()
    {
        return queueArray[front];
    }

    private bool IsFull()
    {
        return count == queueArray.Length;
    }

    private bool IsEmpty()
    {
        return count == 0;
    }

    public void PrintQueue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        for (int i = front; i <= rear; i++)
        {
            Console.WriteLine(queueArray[i]);
        }
    }

    public void Clear()
    {
        front = 0;
        rear = -1;
        count = 0;

        queueArray = new T[DEFAULT_SIZE];
    }

    public int Count()
    {
        return count;
    }

    // Extend method for increasing the size of the underlying array, it prevents exceeding the range
    private void Extend()
    {
        Array.Resize(ref queueArray, queueArray.Length * 2);
        front = 0;
        rear = count - 1;
    }

    // Shrink method for reducing the size of the underlying array
    private void Shrink()
    {
        int capacity = queueArray.Length / 2;

        var newArray = new T[capacity];
        Array.Copy(queueArray, front, newArray, 0, count);
        queueArray = newArray;

        front = 0;
        rear = count - 1;
    }

}
