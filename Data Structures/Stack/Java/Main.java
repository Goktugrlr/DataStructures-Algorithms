public class Main {

    public static void main(String[] args) {
        // Create an Integer stack
        Stack<Integer> intStack = new Stack<>();

        intStack.push(10);
        intStack.push(20);
        intStack.push(30);
        intStack.push(40);

        System.out.println("int stack contents (LIFO):");
        intStack.printStack();

        System.out.println("\nPeek: " + intStack.peek());
        System.out.println("Popped: " + intStack.pop());

        System.out.println("\nStack after pop:");
        intStack.printStack();

        System.out.println("\nElement count in the stack: " + intStack.count());

        intStack.push(32);
        intStack.push(96);
        intStack.push(64);
        intStack.push(128);

        System.out.println("\nStack after pushes:");
        intStack.printStack();

        System.out.println();

        // Create a String stack
        Stack<String> strStack = new Stack<>();

        strStack.push("ABC");
        strStack.push("DEF");
        strStack.push("GHI");

        strStack.pop();

        System.out.println("string stack contents (LIFO):");
        strStack.printStack();
    }
}
