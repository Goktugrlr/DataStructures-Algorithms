using System;
using System.Collections;
using System.Collections.Generic;

public class SinglyLinkedList<T>: IEnumerable<T>
{
    // Represents the first node in the linked list.
    public Node<T> Head { get; private set; }

    // Represents the last node in the linked list.
    public Node<T> Tail { get; private set; }

    public void InsertFirst(T data)
    {
        Node<T> node = new(data);

        if (Head is null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            node.Next = Head;
            Head = node;
        }
    }

    public void InsertEnd(T data)
    {
        Node<T> node = new(data);

        if (Head is null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Tail.Next = node;
            Tail = node;
        }
    }
    
    public void InsertEnd(IEnumerable<T> data)
    {
        foreach (T item in data)
        {
            InsertEnd(item);
        }
    }

    public void InsertMiddle(T data)
    {
        if (Head is null)
        {
            InsertFirst(data);
            return;
        }

        int middleIndex = this.Count() / 2;
        Node<T> current = Head;
        Node<T> newNode = new Node<T>(data);

        for (int i = 1; i<middleIndex; i++)
        {
            current = current.Next;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
        
        if (newNode.Next == null)
        {
            Tail = newNode;
        }
    }

    public void InsertAt(int index, T data)
    {
        if (index < 0 || index >= this.Count())
        {
            throw new ArgumentOutOfRangeException();
        }

        if (index == 0)
        {
            InsertFirst(data);
            return;
        }

        Node<T> newNode = new Node<T>(data);
        Node<T> current = Head;

        for (int i = 1; i < index; i++)
        {
            current = current.Next;
        }
        
        newNode.Next = current.Next;
        current.Next = newNode;

        if (newNode.Next == null)
        {
            Tail = newNode;
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= this.Count())
        {
            throw new ArgumentOutOfRangeException();
        }

        if (index == 0)
        {
            RemoveFirst();
            return;
        }

        Node<T> current = Head; 

        for (int i = 1; i < index; i++)
        {
            current = current.Next;
        }

        current.Next = current.Next.Next;

        if (current.Next == null)
        {
            Tail = current;
        }

    }

    public void RemoveFirst()
    {
        if (Head is not null)
        {
            Head = Head.Next;
        }

        // else list is already empty
    }

    public void RemoveLast()
    {
        if (Head is null)
        {
            // List is empty
            return;
        }

        if (Head == Tail)
        {
            // Only One Node in the List
            Head = Tail = null;
            return;
        }

        Node<T> previous = Head;
        while (previous.Next != Tail)
        {
            previous = previous.Next;
        }

        Tail = previous;
        Tail.Next = null;
    }

    public void RemoveAllByValue(T data)
    {
        if (Head == null)
            return;

        Node<T> current = Head;
        Node<T> previous = null;

        while (current is not null)
        {
            if (current.Data.Equals(data))
            {
                if (current == Head)
                {
                    Head = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                }

                if (current == Tail)
                {
                    Tail = previous;
                }
            }
            else
            {
                previous = current;
            }
 
            current = current.Next;
        }
    }

    public bool Contains(T data)
    {
        Node<T> current = Head;

        while(current != null)
        {
            if (current.Data.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }

        return false;
    }

    public void Reverse()
    {
        Node<T> current = Head;
        Node<T> next = null;
        Node<T> prev = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        Tail = Head;
        Head = prev;
    }

    public void CountOccurence(T data)
    {
        Node<T> current = Head;
        int counter = 0;

        while(current != null)
        {
            if (current.Data.Equals(data))
            {
                counter++;
            }

            current = current.Next;
        }

        Console.WriteLine(data + " is encountered for " + counter + " times.");
    }

    public void ClearAll()
    {
        Head = null;
        Tail = null;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = Head;
        while (current is not null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


public class Node<T>
{
    public T Data { get; set; }

    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
    }

}
