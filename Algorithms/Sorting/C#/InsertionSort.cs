using System;

public class Sorting
{
    public static void Main(string[] args)
    {
        int[] numbers = { 8, 20, 3, 43, 12, 125, 86, 63, 28 };
        string[] names = { "Oliver", "Nathan", "Ellie", "Jorge", "Eleni" };

        void InsertionSort(int[] array) //Non-Generic Insertion Sort Implementation
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        InsertionSort(numbers);

        foreach (int sortedNumbers in numbers)
        {
            Console.Write(sortedNumbers + " ");
        }

        Console.WriteLine();


        void GenericInsertionSort<T>(T[] array) where T : IComparable  //Generic Insertion Sort Implementation
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        GenericInsertionSort(numbers);
        GenericInsertionSort(names);


        foreach (int sortedNumbers in numbers)
        {
            Console.Write(sortedNumbers + " ");
        }

        Console.WriteLine();

        foreach (string sortedNames in names)
        {
            Console.Write(sortedNames + " ");
        }
    }
}
