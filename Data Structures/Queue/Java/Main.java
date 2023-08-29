public class Main {
    public static void main(String[] args) {
        try {
            // Create an Integer queue
            Queue<Integer> intQueue = new Queue<>();

            intQueue.enqueue(10);
            intQueue.enqueue(20);
            intQueue.enqueue(30);
            intQueue.enqueue(40);

            System.out.println("int queue contents (FIFO):");
            intQueue.printQueue();

            System.out.println("\nPeek: " + intQueue.peek());
            System.out.println("Dequeued: " + intQueue.dequeue());

            System.out.println("\nQueue after dequeue:");
            intQueue.printQueue();

            System.out.println("\nElement count in the queue: " + intQueue.count());

            intQueue.enqueue(32);
            intQueue.enqueue(96);
            intQueue.enqueue(64);
            intQueue.enqueue(128);

            System.out.println("\nQueue after enqueues:");
            intQueue.printQueue();

            intQueue.clear();
            System.out.println("\nQueue after Clear method:");
            intQueue.printQueue();

            System.out.println();

            // Create a string queue
            Queue<String> strQueue = new Queue<>();

            strQueue.enqueue("ABC");
            strQueue.enqueue("DEF");
            strQueue.enqueue("GHI");

            strQueue.dequeue();

            System.out.println("string queue contents (FIFO):");
            strQueue.printQueue();

            System.out.println();

            // Create an Integer queue with specified capacity
            Queue<Integer> intQueue2 = new Queue<>(10);
            intQueue2.dequeue();
        }
        catch (IllegalStateException e){
            System.out.println(e.getMessage());
        }
    }
}
