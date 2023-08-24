public class SinglyLinkedList <T>{
    // Represents the first node in the linked list
    private Node<T> head;

    // Represents the last node in the linked list
    private Node<T> tail;

    public void insertFirst(T data){
        Node<T> node = new Node<>(data);

        if (head == null){
            head = node;
            tail = node;
        }
        else {
            node.next = head;
            head = node;
        }
    }

    public void insertEnd(T data){
        Node<T> node = new Node<>(data);

        if (head == null){
            head = node;
            tail = node;
        }
        else {
            tail.next = node;
            tail = node;
        }
    }

    public void insertMiddle(T data){
        if (head == null) {
            insertFirst(data);
            return;
        }

        int middleIndex = count() / 2;
        Node<T> current = head;
        Node<T> newNode = new Node<>(data);

        for (int i = 1; i < middleIndex; i++) {
            current = current.next;
        }

        newNode.next = current.next;
        current.next = newNode;

        // If the newNode is inserted at the end, update the tail to the newNode
        if (newNode.next == null) {
            tail = newNode;
        }
    }

    public void insertAt(int index, T data){
        try {
            if (index < 0 || index >= count()) {
                throw new IndexOutOfBoundsException("Index out of bounds: " + index);
            }

            if (index == 0) {
                insertFirst(data);
                return;
            }

            Node<T> newNode = new Node<>(data);
            Node<T> current = head;

            for (int i = 1; i < index; i++) {
                current = current.next;
            }

            newNode.next = current.next;
            current.next = newNode;

            if (newNode.next == null) {
                tail = newNode;
            }
        } catch (IndexOutOfBoundsException e) {
            System.out.println("Invalid index. Insertion not performed. " + e.getMessage());
        }
    }

    public void removeAt(int index) {
        try {
            if (index < 0 || index >= count()) {
                throw new IndexOutOfBoundsException("Index out of bounds: " + index);
            }

            if (index == 0) {
                removeFirst();
                return;
            }

            Node<T> current = head;

            for (int i = 1; i < index; i++) {
                current = current.next;
            }

            current.next = current.next.next;

            if (current.next == null) {
                tail = current;
            }
        } catch (IndexOutOfBoundsException e) {
            System.out.println("Invalid index. Removal not performed. " + e.getMessage());
        }
    }

    public void removeFirst(){
        if (head != null){
            head = head.next;
        }
        // else list is already empty
    }

    public void removeLast(){
        if (head == null){
            // List is empty
            return;
        }
        else if (head == tail){
            // Only one node exists in the List
            head = tail = null;
            return;
        }

        Node<T> previous = head;
        while (previous.next != tail){
            previous = previous.next;
        }

        tail = previous;
        tail.next = null;
    }

    public void removeAllByValue(T data){
        if (head == null) {
            return;
        }

        Node<T> current = head;
        Node<T> previous = null;

        while (current != null) {
            if (current.data.equals(data)) {
                if (current == head) {
                    head = current.next;
                } else {
                    previous.next = current.next;
                }

                if (current == tail) {
                    tail = previous;
                }
            } else {
                previous = current;
            }

            current = current.next;
        }
    }

    public boolean contains(T data){
        Node<T> current = head;

        while(current != null){
            if (current.data.equals(data)){
                return true;
            }
            current = current.next;
        }
        return false;
    }

    public void reverse() {
        Node<T> current = head;
        Node<T> next = null;
        Node<T> prev = null;

        while (current != null) {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        tail = head;
        head = prev;
    }

    public void countOccurrence(T data) {
        Node<T> current = head;
        int counter = 0;

        while (current != null) {
            if (current.data.equals(data)) {
                counter++;
            }
            current = current.next;
        }

        System.out.println(data + " is encountered for " + counter + " times.");
    }

    public void clearAll() {
        head = null;
        tail = null;
    }

    private int count() {
        int count = 0;
        Node<T> current = head;

        while (current != null) {
            count++;
            current = current.next;
        }

        return count;
    }

    public void display() {
        Node<T> current = head;
        while (current != null) {
            System.out.print(current.data);
            System.out.print(" -> ");
            current = current.next;
        }
        System.out.println("null");
    }
}

// Creating Node Class for Nodes
class Node<T> {
    T data;
    Node<T> next;

    // Constructor of Node
    Node(T data){
        this.data = data;
    }
}
