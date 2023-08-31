from singly_linked_list import SinglyLinkedList


def main():
    try:
        # Creating an instance
        linked_list = SinglyLinkedList()

        linked_list.insert_end(2)
        #  2 -> null

        linked_list.insert_end(3)
        # 2 -> 3 -> null

        linked_list.insert_first(12)
        # 12 -> 2 -> 3 -> null

        linked_list.insert_end(14)
        # 12 -> 2 -> 3 -> 14 -> null

        linked_list.insert_middle(8)
        # 12 -> 2 -> 8 -> 3 -> 14 -> null

        linked_list.insert_at(3, 27)
        # 12 -> 2 -> 8 -> 27 -> 3 -> 14 -> null

        linked_list.remove_at(4)
        # 12 -> 2 -> 8 -> 27 -> 14 -> null

        linked_list.remove_first()
        # 2 -> 8 -> 27 -> 14 -> null

        linked_list.remove_last()
        # 2 -> 8 -> 27 -> null

        linked_list.insert_end(8)
        linked_list.insert_end(10)
        linked_list.insert_end(12)
        # 2 -> 8 -> 27 -> 8 -> 10 -> 12 -> null

        linked_list.count_occurrence(8)
        # 8 is encountered for 2 times.

        linked_list.remove_all_by_value(8)
        # 2 -> 27 -> 10 -> 12 -> null

        linked_list.reverse()
        # 12 -> 10 -> 27 -> 2 -> null

        print(linked_list.contains(12))
        # True

        print(linked_list.contains(8))
        # False

        linked_list.display()

        linked_list.clear_all()
        linked_list.display()
    except ValueError as e:
        print(e)


if __name__ == "__main__":
    main()
