public class Sorting {

    // Non-Generic Bubble Sort Implementation for primitive int array
    public static void BubbleSort(int[] array){
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length - i - 1; j++) {
                if (array[j] > (array[j + 1])){
                    var temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // Generic Bubble Sort Implementation for any Comparable Type
    public static <T extends Comparable<T>> void GenericBubbleSort(T[] array){
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length - i - 1; j++) {
                if (array[j].compareTo(array[j + 1]) > 0) {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }


    public static void main(String[] args) {
        // Sorting primitive int array
        int[] numbers = {8, 20, 3, 43, 12, 125, 86, 63, 28};
        BubbleSort(numbers);

        for (int sortedNumbers : numbers) {
            System.out.print(sortedNumbers + " ");
        }
        System.out.println();

        // Sorting Integer array (Generic version)
        Integer[] integerNumbers  = {8, 20, 3, 43, 12, 125, 86, 63, 28};  //Defining Non-Primitive Data Type for Generic Sort
        GenericBubbleSort(integerNumbers );

        for (Integer sortedNumbers : integerNumbers ) {
            System.out.print(sortedNumbers + " ");
        }
        System.out.println();

        // Sorting String array (Generic version)
        String[] names = { "Oliver", "Nathan", "Ellie", "Jorge", "Eleni" };
        GenericBubbleSort(names);

        for (String sortedNames : names) {
            System.out.print(sortedNames + " ");
        }
    }

}
