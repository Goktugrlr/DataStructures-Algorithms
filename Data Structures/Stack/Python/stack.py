class Stack:
    def __init__(self, initial_size=50):
        self.stack_arr = [None] * initial_size
        self.top = -1

    # Push function for adding an element to the top of a stack (LIFO)
    def push(self, data):
        if self.is_full():
            self.extend()

        self.top += 1
        self.stack_arr[self.top] = data

    # Pop function for removing an element from the top of a stack
    def pop(self):
        if self.is_empty():
            raise ValueError("Cannot pop from an empty stack.")

        item = self.stack_arr[self.top]
        self.stack_arr[self.top] = None
        self.top -= 1

        if self.top == len(self.stack_arr) // 4:
            self.shrink()

        return item

    # Peek function for getting value of the top element
    def peek(self):
        return self.stack_arr[self.top]

    # Count function for getting element count in the stack
    def count(self):
        return self.top + 1

    def is_full(self):
        return self.top == len(self.stack_arr) - 1

    def is_empty(self):
        return self.top == -1

    def print_stack(self):
        if self.is_empty():
            print("Stack is empty.")

        for i in range(self.top, -1, -1):
            print(self.stack_arr[i])

    # Extend function for increasing the size of the underlying array, it prevents exceeding the range
    def extend(self):
        new_array = [None] * (len(self.stack_arr) * 2)
        new_array[:len(self.stack_arr)] = self.stack_arr
        self.stack_arr = new_array

    # Shrink function for reducing the size of the underlying array
    def shrink(self):
        new_array = [None] * (len(self.stack_arr) // 2)
        new_array[:self.top + 1] = self.stack_arr[:self.top + 1]
        self.stack_arr = new_array
