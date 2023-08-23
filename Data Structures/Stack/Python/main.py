from stack import Stack


def main():
    try:
        # Create an int Stack
        int_stack = Stack()

        int_stack.push(10)
        int_stack.push(20)
        int_stack.push(30)
        int_stack.push(40)

        print("Integer stack contents (LIFO):")
        int_stack.print_stack()

        print("\nPeek:", int_stack.peek())
        print("Popped:", int_stack.pop())

        print("\nStack after pop:")
        int_stack.print_stack()

        print("\nElement count in the stack:", int_stack.count())

        int_stack.push(32)
        int_stack.push(96)
        int_stack.push(64)
        int_stack.push(128)

        print("\nStack after pushes:")
        int_stack.print_stack()

        print()

        # Create a String Stack
        str_stack = Stack()

        str_stack.push("ABC")
        str_stack.push("DEF")
        str_stack.push("GHI")

        str_stack.pop()

        print("String stack contents (LIFO):")
        str_stack.print_stack()

        print()

        # Create an int Stack with Specified Capacity
        int_stack2 = Stack(initial_size=10)
        int_stack2.pop()
    except ValueError as e:
        print(e)


if __name__ == "__main__":
    main()
