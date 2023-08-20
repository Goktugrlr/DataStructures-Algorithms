public class Stack <T>{

    private T[] stackArray;
    private int top;

    /*
    @SuppressWarnings("unchecked") annotations are used to prevent the "Unchecked cast" error
    */
    
    // Default Constructor
    @SuppressWarnings("unchecked")
    public Stack(){
        int DEFAULT_SIZE = 50;
        stackArray = (T[]) new Object[DEFAULT_SIZE];
        top = -1;
    }

    // Parameterized Constructor with Specific Size
    @SuppressWarnings("unchecked")
    public Stack(int initialSize){
        stackArray = (T[]) new Object[initialSize];
        top = -1;
    }

    // Push method for adding an element to the top of a stack (LIFO)
    public void push(T data){
        if (isFull()){
            extend();
        }

        top++;
        stackArray[top] = data;
    }

    // Pop method for removing an element from the top of a stack
    public T pop(){
        if (isEmpty()) {
            throw new IllegalStateException("Cannot pop from an empty stack.");
        }

        T item = stackArray[top];
        stackArray[top] = null;
        top--;

        if (top == stackArray.length / 4){
            shrink();
        }

        return item;
    }

    // Peek method for getting value of the top element
    public T peek(){
        return stackArray[top];
    }

    // Count method for getting element count in the stack
    public int count(){
        return top + 1;
    }

    private boolean isFull(){
        return top == stackArray.length - 1;
    }

    private boolean isEmpty(){
        return top == -1;
    }

    public void printStack(){
        if (isEmpty()){
            System.out.println("Stack is empty.");
            return;
        }

        for (int i = top; i >= 0; i--){
            System.out.println(stackArray[i]);
        }
    }

    // Extend method for increasing the size of the underlying array, it prevents exceeding the range
    @SuppressWarnings("unchecked")
    private void extend(){
        T[] newArray = (T[]) new Object[stackArray.length * 2];
        System.arraycopy(stackArray, 0, newArray, 0, stackArray.length);
        stackArray = newArray;
    }

    // Shrink method for reducing the size of the underlying array
    @SuppressWarnings("unchecked")
    private void shrink(){
        T[] newArray = (T[]) new Object[stackArray.length / 2];
        System.arraycopy(stackArray, 0, newArray, 0, top + 1);
        stackArray = newArray;
    }
}
