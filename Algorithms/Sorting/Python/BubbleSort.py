def bubble_sort(arr):
    for i in range(0, len(arr)):
        for j in range(0, len(arr) - i - 1):
            if arr[j] > arr[j + 1]:
                temp = arr[j]
                arr[j] = arr[j + 1]
                arr[j + 1] = temp
                #arr[j], arr[j + 1] = arr[j + 1], arr[j]


# Sorting integers
numbers = [8, 20, 3, 43, 12, 125, 86, 63, 28]
bubble_sort(numbers)
for sortedNumbers in numbers:
    print(sortedNumbers, end=" ")

print()
# Sorting strings
names = ["Oliver", "Nathan", "Ellie", "Jorge", "Eleni"]
bubble_sort(names)
for sortedNames in names:
    print(sortedNames, end=" ")

# Note: In contrast to languages like Java and C#, Python's dynamic typing and duck typing enable this function to work with
# various data types, similar to how a generic function behaves in Java or C#.
