public class Main {
    public static void main(String[] args) {
        SinglyLinkedList<Integer> list = new SinglyLinkedList<>();

        list.insertEnd(2);
        // 2 -> null

        list.insertEnd(3);
        // 2 -> 3 -> null

        list.insertFirst(12);
        // 12 -> 2 -> 3 -> null

        list.insertEnd(14);
        // 12 -> 2 -> 3 -> 14 -> null

        list.insertMiddle(8);
        // 12 -> 2 -> 8 -> 3 -> 14 -> null

        list.insertAt(3, 27);
        // 12 -> 2 -> 8 -> 27 -> 3 -> 14 -> null

        list.removeAt(4);
        // 12 -> 2 -> 8 -> 27 -> 14 -> null

        list.removeFirst();
        // 2 -> 8 -> 27 -> 14 -> null

        list.removeLast();
        // 2 -> 8 -> 27 -> null

        list.insertEnd(8);
        list.insertEnd(10);
        list.insertEnd(12);
        // 2 -> 8 -> 27 -> 8 -> 10 -> 12 -> null

        list.countOccurrence(8);
        // 8 is encountered for 2 times.

        list.removeAllByValue(8);
        // 2 -> 27 -> 10 -> 12 -> null

        list.reverse();
        // 12 -> 10 -> 27 -> 2 -> null

        System.out.println(list.contains(12));
        // True

        System.out.println(list.contains(8));
        // False

        list.display();

        // Clear the Whole Linked List
        list.clearAll();
        list.display();
    }
}
