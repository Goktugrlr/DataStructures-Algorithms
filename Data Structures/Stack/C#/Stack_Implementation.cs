using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T>
{
    private const int DEFAULT_SIZE = 50;
    private T[] stackArray;
    private int top;

    public Stack(int initialSize = DEFAULT_SIZE)
    {
        stackArray = new T[initialSize];
        top = -1;
    }

    // Push method for adding an element to the top of a stack (LIFO)
    public void Push(T element)
    {
        if (IsFull())
        {
            Extend();
        }

        top++;
        stackArray[top] = element;
    }

    // Pop method for removing an element from the top of a stack
    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Cannot pop from an empty stack.");
        }

        T item = stackArray[top];
        stackArray[top] = default; // Sets the value at the top of the stack to the default value of the type T
        top--;

        // Checking if the stack has become significantly smaller (25% of its capacity) compared to its length
        if (top == stackArray.Length / 4)
        {
            Shrink();
        }

        return item;
    }

    // Peek method for getting value of the top element
    public T Peek()
    {
        return stackArray[top];
    }

    // Count method for getting element count in the stack
    public int Count()
    {
        return top + 1;
    }

    private bool IsFull()
    {
        return top == stackArray.Length - 1;
    }

    private bool IsEmpty()
    {
        return top == -1;
    }

    public void PrintStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stackArray[i]);
        }
    }

    // Extend method for increasing the size of the underlying array, it prevents exceeding the range
    private void Extend()
    {
        var newArray = new T[stackArray.Length * 2];
        Array.Copy(stackArray, newArray, stackArray.Length);
        stackArray = newArray;
    }

    // Shrink method for reducing the size of the underlying array
    private void Shrink()
    {
        var newArray = new T[stackArray.Length / 2];
        Array.Copy(stackArray, 0, newArray, 0, top + 1);
        stackArray = newArray;
    }

}
