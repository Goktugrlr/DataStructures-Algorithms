public class Queue <T>{
    private T[] queueArray;
    private int rear, front;
    private int count;
    private final int DEFAULT_SIZE = 50;

    /*
    @SuppressWarnings("unchecked") annotations are used to prevent the "Unchecked cast" error
    */

    // Default Constructor
    @SuppressWarnings("unchecked")
    public Queue(){
        queueArray = (T[]) new Object[DEFAULT_SIZE];

        // rear and front variables represent their index
        this.rear = -1;
        this.front = 0;
        // count variable represents the element count in the array
        this.count = 0;
    }

    // Parameterized Constructor with Specific Size
    @SuppressWarnings("unchecked")
    public Queue(int initialSize){
        queueArray = (T[]) new Object[initialSize];
        this.rear = 0;
        this.front = 0;
        this.count = 0;
    }

    // Enqueue method for adding an element to the rear of a queue (FIFO)
    public void enqueue(T data){
        if (isFull()){
            extend();
        }

        rear++;
        queueArray[rear] = data;
        count++;
    }

    // Dequeue method for removing an element from the front of a queue (FIFO)
    public T dequeue(){
        if (isEmpty()){
            throw new IllegalStateException("Queue is empty. Dequeue cannot performed.");
        }

        T item = queueArray[front];
        queueArray[front] = null;
        front++;
        count--;

        // Checking if the queue has become significantly smaller (25% of its capacity) compared to its length
        if (count == queueArray.length / 4){
            shrink();
        }

        return item;
    }

    // Peek method for getting value of the front element
    public T peek(){
        return queueArray[front];
    }

    private boolean isFull(){
        return count == queueArray.length;
    }

    private boolean isEmpty(){
        return count == 0;
    }

    public void printQueue(){
        if (isEmpty()){
            System.out.println("Queue is empty.");
            return;
        }

        for (int i = front; i <= rear; i++)
        {
            System.out.println(queueArray[i]);
        }
    }

    @SuppressWarnings("unchecked")
    public void clear() {
        front = 0;
        rear = -1;
        count = 0;

        T[] newArray = (T[]) new Object[queueArray.length];
        System.arraycopy(queueArray, 0, newArray, 0, count);
        queueArray = newArray;
    }

    // Since count is declared as private the method provides access to the private 'count' variable
    public int count(){
        return count;
    }

    // Extend method for increasing the size of the underlying array, it prevents exceeding the range
    @SuppressWarnings("unchecked")
    private void extend(){
        T[] newArray = (T[]) new Object[queueArray.length * 2];
        System.arraycopy(queueArray, 0, newArray, 0, queueArray.length);
        queueArray = newArray;
    }

    // Shrink method for reducing the size of the underlying array
    @SuppressWarnings("unchecked")
    private void shrink(){
        T[] newArray = (T[]) new Object[queueArray.length / 2];
        System.arraycopy(queueArray, 0, newArray, 0, count);
        queueArray = newArray;
    }
}
