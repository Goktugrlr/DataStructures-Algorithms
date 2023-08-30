from queue import Queue


def main():
    try:
        # Create an int Queue
        int_queue = Queue()

        int_queue.enqueue(10)
        int_queue.enqueue(20)
        int_queue.enqueue(30)
        int_queue.enqueue(40)

        print("Integer queue contents (FIFO):")
        int_queue.print_queue()

        print("\nPeek:", int_queue.peek())
        print("Dequeued:", int_queue.dequeue())

        print("\nQueue after dequeue:")
        int_queue.print_queue()

        print("\nElement count in the queue:", int_queue.get_count())

        int_queue.enqueue(32)
        int_queue.enqueue(96)
        int_queue.enqueue(64)
        int_queue.enqueue(128)

        print("\nQueue after enqueues:")
        int_queue.print_queue()

        print()

        # Create a String Queue
        str_queue = Queue()

        str_queue.enqueue("ABC")
        str_queue.enqueue("DEF")
        str_queue.enqueue("GHI")

        str_queue.dequeue()

        print("String queue contents (FIFO):")
        str_queue.print_queue()

        print()

        # Create an int Queue with Specified Capacity
        int_queue2 = Queue(initial_size=10)
        int_queue2.dequeue()
    except ValueError as e:
        print(e)


if __name__ == "__main__":
    main()
