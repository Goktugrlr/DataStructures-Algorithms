def insertion_sort(arr):
    for i in range(1, len(arr)):
        key = arr[i]
        j = i - 1

        while j >= 0 and arr[j] > key:
            arr[j + 1] = arr[j]
            j -= 1

        arr[j + 1] = key


# Sorting integers
numbers = [8, 20, 3, 43, 12, 125, 86, 63, 28]
insertion_sort(numbers)
for sortedNumbers in numbers:
    print(sortedNumbers, end=" ")

print()
# Sorting strings
names = ["Oliver", "Nathan", "Ellie", "Jorge", "Eleni"]
insertion_sort(names)
for sortedNames in names:
    print(sortedNames, end=" ")

# Note: In contrast to languages like Java and C#, Python's dynamic typing and duck typing enable this function to work
# with various data types, similar to how a generic function behaves in Java or C#.
