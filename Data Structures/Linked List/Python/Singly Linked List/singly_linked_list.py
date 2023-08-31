class SinglyLinkedList:
    def __init__(self):
        # Represents the first node in the linked list
        self.head = None

        # Represents the last node in the linked list
        self.tail = None

    def insert_first(self, data):
        new_node = Node(data)

        if self.head is None:
            self.head = new_node
            self.tail = new_node
        else:
            new_node.next = self.head
            self.head = new_node

    def insert_end(self, data):
        new_node = Node(data)

        if self.head is None:
            self.head = new_node
            self.tail = new_node
        else:
            self.tail.next = new_node
            self.tail = new_node

    def insert_middle(self, data):
        if self.head is None:
            self.insert_first(data)

        middle_index = self.count() // 2
        current = self.head
        new_node = Node(data)

        for i in range(1, middle_index):
            current = current.next

        new_node.next = current.next
        current.next = new_node

        # If the new_node is inserted at the end, update the tail to the new_node
        if new_node.next is None:
            self.tail = new_node

    def insert_at(self, index, data):
        if index < 0 or index > self.count():
            raise ValueError(f"Index out of range: {index}")

        if index == 0:
            self.insert_first(data)
            return

        current = self.head
        new_node = Node(data)

        for i in range(1, index):
            current = current.next

        new_node.next = current.next
        current.next = new_node

        if new_node.next is None:
            self.tail = new_node

    def remove_at(self, index):
        if index < 0 or index >= self.count():
            raise ValueError(f"Index out of range: {index}")

        if index == 0:
            self.remove_first()
            return

        current = self.head

        for i in range(1, index):
            current = current.next

        current.next = current.next.next

        if current.next is None:
            self.tail = current

    def remove_first(self):
        if self.head:
            self.head = self.head.next
        # else list is already empty

    def remove_last(self):
        if self.head is None:
            # List is empty
            return
        elif self.head == self.tail:
            # Only one node exists in the list
            self.head = self.tail = None
            return

        previous = self.head
        while previous.next != self.tail:
            previous = previous.next

        self.tail = previous
        self.tail.next = None

    def remove_all_by_value(self, data):
        if self.head is None:
            return

        current = self.head
        previous = None

        while current is not None:
            if current.data == data:
                if current == self.head:
                    self.head = current.next
                else:
                    previous.next = current.next

                if current == self.tail:
                    self.tail = previous
            else:
                previous = current

            current = current.next

    def contains(self, data):
        current = self.head

        while current is not None:
            if current.data == data:
                return True
            current = current.next

        return False

    def reverse(self):
        current = self.head
        next_node = None
        prev_node = None

        while current is not None:
            next_node = current.next
            current.next = prev_node
            prev_node = current
            current = next_node

        self.tail = self.head
        self.head = prev_node

    def count_occurrence(self, data):
        current = self.head
        counter = 0

        while current is not None:
            if current.data == data:
                counter += 1
            current = current.next

        print(f"{data} is encountered for {counter} times.")

    def clear_all(self):
        self.head = None
        self.tail = None

    def count(self):
        current = self.head
        counter = 0

        while current is not None:
            counter += 1
            current = current.next

        return counter

    def display(self):
        current = self.head

        while current is not None:
            print(current.data, "->", end=" ")
            current = current.next

        print("null")


# Creating Node Class for Nodes
class Node:
    def __init__(self, data):
        self.data = data
        self.next = None
