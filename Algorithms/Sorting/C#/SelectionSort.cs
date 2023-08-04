using System;

public class Sorting
{
    public static void Main(string[] args)
    {
        int[] numbers = { 8, 20, 3, 43, 12, 125, 86, 63, 28 };
        string[] names = { "Oliver", "Nathan", "Ellie", "Jorge", "Eleni" };

        void SelectionSort(int[] array) //Non-Generic Selection Sort Implementation
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
        
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex]) 
                    { 
                        minIndex = j;
                    }
                }
                
                var temp = array[minIndex]; 
                array[minIndex] = array[i];
                array[i] = temp;    
            }
        }

        SelectionSort(numbers);

        foreach (int sortedNumbers in numbers)
        {
            Console.Write(sortedNumbers + " ");
        }

        Console.WriteLine();


        
        void GenericSelectionSort<T>(T[] array) where T : IComparable  //Generic Selection Sort Implementation
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                var temp = array[minIndex];
                array[minIndex] = array[i];
                array [i] = temp;   
            }
        }

        GenericSelectionSort(numbers);
        GenericSelectionSort(names);

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
