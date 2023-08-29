class Queue:
    def __init__(self, initial_size=50):
        self.queue_arr = [None] * initial_size
        self.rear = -1
        self.front = 0
        self.count = 0

    # Enqueue function for adding an element to the rear of a queue (FIFO)
    def enqueue(self, data):
        if self.is_full():
            self.extend()

        self.rear += 1
        self.queue_arr[self.rear] = data
        self.count += 1

    # Dequeue function for removing an element from the front of a queue (FIFO)
    def dequeue(self):
        if self.is_empty():
            raise ValueError("Queue is empty. Dequeue cannot performed.")

        item = self.queue_arr[self.front]
        self.queue_arr[self.front] = None
        self.front += 1
        self.count -= 1

        # Checking if the queue has become significantly smaller (25% of its capacity) compared to its length
        if self.count == len(self.queue_arr) // 4:
            self.shrink()

        return item

    # Peek function for getting value of the front element
    def peek(self):
        return self.queue_arr[self.front]

    # Count function for getting element count in the stack
    def get_count(self):
        return self.count

    def is_full(self):
        return self.count == len(self.queue_arr)

    def is_empty(self):
        return self.count == 0

    def print_queue(self):
        if self.is_empty():
            print("Queue is empty.")
            return

        for i in range(self.front, self.rear + 1):
            print(self.queue_arr[i])

    # Extend function for increasing the size of the underlying array, it prevents exceeding the range
    def extend(self):
        new_array = [None] * (len(self.queue_arr) * 2)
        new_array[:len(self.queue_arr)] = self.queue_arr
        self.queue_arr = new_array

    # Shrink function for reducing the size of the underlying array
    def shrink(self):
        new_array = [None] * (len(self.queue_arr) // 2)
        new_array[:self.front + 1] = self.queue_arr[:self.front + 1]
        self.queue_arr = new_array
