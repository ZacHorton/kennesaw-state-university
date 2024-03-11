def Compare(array1, array2):
    if array1 == array2:
        return True
    else:
        return False


def main():
    x = int(input('Please enter the array size '))
    array1 = []
    array2 = []
    for element in range(0, x):
        value = int(input('Please initialize the first array with integer values. '))
        array1.append(value)
    for element in range(0, x):
        value = int(input('Please initialize the second array with integer values. '))
        array2.append(value)
    if Compare(array1,array2) == True:
        judgment = 'The arrays are identical '
    else:
        judgment = 'The arrays are not identical'
    print('Array size:   ', x)
    print('First array:', end='   ')
    print(*array1, sep=', ')
    print('Second array:', end='  ')
    print(*array2, sep=', ')
    print('Judgment:     ', judgment)


main()
