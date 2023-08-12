def selection_sort(arr):
    for i in range(0, len(arr)):
        minIndex = i
        for j in range(i + 1, len(arr)):
            if arr[j] < arr[minIndex]:
                minIndex = j

        temp = arr[minIndex]
        arr[minIndex] = arr[i]
        arr[i] = temp
        #arr[i], arr[minIndex] = arr[minIndex], arr[i]


# Sorting integers
numbers = [8, 20, 3, 43, 12, 125, 86, 63, 28]
selection_sort(numbers)
for sortedNumbers in numbers:
    print(sortedNumbers, end=" ")

print()
# Sorting strings
names = ["Oliver", "Nathan", "Ellie", "Jorge", "Eleni"]
selection_sort(names)
for sortedNames in names:
    print(sortedNames, end=" ")

# Note: In contrast to languages like Java and C#, Python's dynamic typing and duck typing enable this function to work
# with various data types, similar to how a generic function behaves in Java or C#.
