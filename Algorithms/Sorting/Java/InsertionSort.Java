public class Sorting {

    public static void InsertionSort(Integer[] array){
        for (int i = 1; i < array.length ; i++){
            int key = array[i];

            int j = i - 1;

            while (j >= 0 && array[j].compareTo(key) > 0){
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    public static void main(String[] args) {
        Integer[] numbers = {8, 20, 3, 43, 12, 125, 86, 63, 28};
        InsertionSort(numbers);

        for (Integer sortedNumbers : numbers) {     //Displaying Sorted List With Enhanced For Loop
            System.out.print(sortedNumbers + " ");
        }
    }

}

