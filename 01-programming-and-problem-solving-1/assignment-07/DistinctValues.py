def getValue(array):
    array2 = []
    for x in array:
        if x not in array2:
            array2.append(x)
    return array2


def main():
    array_values = input('Please input 10 integers separated by a space. ')
    array1 = list(map(int, array_values.split()))
    print('Original array:', *array1)
    array2 = getValue(array1)
    print('Distinct array:', *array2)


main()
