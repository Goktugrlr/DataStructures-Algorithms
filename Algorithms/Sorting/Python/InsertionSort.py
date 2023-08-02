def insertion_sort(numbers):
    for i in range(1, len(numbers)):
        key = numbers[i]
        j = i - 1

        while j >= 0 and numbers[j] > key:
            numbers[j + 1] = numbers[j]
            j -= 1

        numbers[j + 1] = key


numberList = [8, 20, 3, 43, 12, 125, 86, 63, 28]

insertion_sort(numberList)

print(numberList)
