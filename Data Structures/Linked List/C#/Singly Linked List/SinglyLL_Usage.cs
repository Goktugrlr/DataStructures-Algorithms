using System;
using System.Collections.Generic;

SinglyLinkedList<int> list = new();

list.InsertEnd(2);
// 2 -> null

list.InsertEnd(3);
// 2 -> 3 -> null

list.InsertFirst(12);
// 12 -> 2 -> 3 -> null

list.InsertEnd(14);
// 12 -> 2 -> 3 -> 14 -> null

list.InsertMiddle(8);
// 12 -> 2 -> 8 -> 3 -> 14 -> null

list.InsertAt(3, 27);
// 12 -> 2 -> 8 -> 27 -> 3 -> 14 -> null

list.RemoveAt(4);
// 12 -> 2 -> 8 -> 27 -> 14 -> null

list.RemoveFirst();
// 2 -> 8 -> 27 -> 14 -> null

list.RemoveLast();
// 2 -> 8 -> 27 -> null

list.InsertEnd(new[] { 8, 10, 12 });
// 2 -> 8 -> 27 -> 8 -> 10 -> 12 -> null

list.CountOccurence(8);
// 8 is encountered for 2 times.

list.RemoveAllByValue(8);
// 2 -> 27 -> 10 -> 12 -> null

list.Reverse();
// 12 -> 10 -> 27 -> 2 -> null

Console.WriteLine(list.Contains(12));
// True

Console.WriteLine(list.Contains(8));
// False

Display();

// Clear the Whole Linked List
list.ClearAll();
Display();


void Display()
{
    foreach (var item in list)
    {
        Console.Write(item);
        Console.Write(" -> ");
    }
    Console.WriteLine("null");    
}
