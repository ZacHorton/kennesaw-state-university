def BubbleSort(array):
    counter = 0
    length = len(array) - 1
    sort = False
    while not sort:
        counter += 1
        sort = True
        for i in range(length):
            if array[i] > array[i+1]:
                sort = False
                array[i], array[i+1] = array[i+1], array[i]
    return array, counter


def InsertionSort(array):
    counter = 0
    for i in range(1, len(array)):
        current = array[i]
        while i > 0 and array[i - 1] > current:
            counter += 1
            array[i] = array[i - 1]
            i = i - 1
            array[i] = current
    return array, counter


def SelectionSort(array):
    counter = 0
    for i in range(len(array)):
        minPosition = i
        for j in range(i+1, len(array)):
            counter += 1
            if array[minPosition] > array[j]:
                minPosition = j
        temp = array[i]
        array[i] = array[minPosition]
        array[minPosition] = temp
    return array, counter


def main():
    import random
    array1 = [random.randint(0, 100) for a in range(50)]
    print('Array Values:', array1)
    print()
    bubble_values, bubble_swaps = BubbleSort(array1)
    print('Bubble Sorted values:', *bubble_values)
    print('Bubble Sort Swaps:', bubble_swaps)
    print()
    insertion_values, insertion_swaps = InsertionSort(array1)
    print('Insertion Sorted values:', *insertion_values)
    print('Insertion Sort Swaps:', insertion_swaps)
    print()
    selection_values, selection_swaps = SelectionSort(array1)
    print('Selection Sorted values:', *selection_values)
    print('Selection Sort Swaps:', selection_swaps)


main()
