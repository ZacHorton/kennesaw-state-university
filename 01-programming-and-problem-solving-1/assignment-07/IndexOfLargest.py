def findIndex(array):
    largest = 0
    for element in range(0, 10):
        if array[element] > largest:
            largest = array[element]
    return array.index(largest)


def main():
    array_values = input('Please input 10 integers separated by a space. ')
    array1 = list(map(int, array_values.split()))
    print('Entered integers:\t', *array1)
    print(f'Index of largest value is {findIndex(array1)}')


main()
