def selection_sort(numbers):
    for i in range(0, len(numbers)):
        minIndex = i
        for j in range(i + 1, len(numbers)):
            if numbers[j] < numbers[minIndex]:
                minIndex = j

        temp = numbers[minIndex]
        numbers[minIndex] = numbers[i]
        numbers[i] = temp


numberList = [8, 20, 3, 43, 12, 125, 86, 63, 28]

selection_sort(numberList)

print(numberList)
