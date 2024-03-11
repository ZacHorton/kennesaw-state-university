def LinearSearch(array, target):
    found = False
    position = 0
    while position < len(array) and not found:
        if array[position] == target:
            found = True
            return position + 1
        position += 1


def BinarySearch(array, target):
    array2 = []
    while array:
        min_index = array.index(min(array))
        array2.append(array.pop(min_index))
    counter = 0
    first = 0
    last = len(array2)-1
    found = False
    while first <= last and not found:
        counter += 1
        midpoint = (first + last)//2
        if target == array2[midpoint]:
            found = True
            return counter
        else:
            if target < array2[midpoint]:
                last = midpoint-1
            else:
                if target > midpoint:
                    first = midpoint+1



def main():
    array_values = input('Please input integers separated by a space. ')
    target_value = int(input('Please input the target value. '))
    array1 = list(map(int, array_values.split()))
    print('Arrays Values:\t', array_values)
    print('Target value:\t', target_value)
    print()
    print('Linear Search Comparisons:', LinearSearch(array1, target_value))
    print('Binary Search Comparisons:', BinarySearch(array1, target_value))


main()
