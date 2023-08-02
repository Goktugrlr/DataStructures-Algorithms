public class Sorting {

    public static void SelectionSort(Integer[] array){
        for (int i = 0; i < array.length; i++){
            int minIndex = i;

            for (int j = i + 1; j < array.length; j++){
                if (array[j].compareTo(array[minIndex]) < 0 ){
                    minIndex = j;
                }
            }
            var temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    public static void main(String[] args) {
        Integer[] numbers = {8, 20, 3, 43, 12, 125, 86, 63, 28};
        SelectionSort(numbers);

        for (Integer sortedNumbers : numbers) {     //Displaying Sorted List With Enhanced For Loop
            System.out.print(sortedNumbers + " ");
        }
    }

}
