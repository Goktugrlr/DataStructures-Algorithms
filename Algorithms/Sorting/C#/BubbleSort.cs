using System;

public class Sorting
{
    public static void Main(string[] args)
    {

        // Non-Generic Bubble Sort Implementation for primitive int array
        void BubbleSort(int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


        // Generic Bubble Sort Implementation for any Comparable Type
        void GenericBubbleSort<T>(T[] array) where T : IComparable  
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }       
            }
        }


        // Sorting primitive int array
        int[] numbers = { 8, 20, 3, 43, 12, 125, 86, 63, 28 };
        BubbleSort(numbers);

        foreach (int sortedNumbers in numbers)
        {
            Console.Write(sortedNumbers + " ");
        }
        Console.WriteLine();


        // Sorting String array (Generic version)
        string[] names = { "Oliver", "Nathan", "Ellie", "Jorge", "Eleni" };
        GenericBubbleSort(names);

        foreach (string sortedNames in names)
        {
            Console.Write(sortedNames + " ");
        }
        Console.WriteLine();


        // Sorting Integer array (Generic version). 
        // Although it has already been sorted in the non-generic version, this demonstrates the usage of the generic sorting method.
        GenericBubbleSort(numbers);

        foreach (int sortedNumbers in numbers)
        {
            Console.Write(sortedNumbers + " ");
        }
    }
}
