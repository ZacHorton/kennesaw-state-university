def findIndex(array):
    compare = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']
    largest = 0
    for element in range(0, 7):
        if array[element] > largest:
            largest = array[element]
    i = array.index(largest)
    return compare[i]


def addHours(array):
    total1 = 0
    total2 = 0
    total3 = 0
    for a in array[0]:
        total1 += a
    for b in array[1]:
        total2 += b
    for c in array[2]:
        total3 += c
    hours = [['1', total1], ['2', total2], ['3', total3]]
    sorted_list = sorted(hours, key=lambda x: x[1])
    print('Employee#\tWeekly Hours')
    print('----------------------------')
    print(f'{sorted_list[0][0]}\t\t\t', sorted_list[0][1])
    print(f'{sorted_list[1][0]}\t\t\t', sorted_list[1][1])
    print(f'{sorted_list[2][0]}\t\t\t', sorted_list[2][1])


def main():
    import random
    array1 = [[random.randint(0, 10) for a in range(7)] for b in range(3)]
    print('Employee Data:')
    print()
    print('\t\t\tMon\t\tTue\t\tWed\t\tThu\t\tFri\t\tSat\t\tSun')
    print('Employee1', end='\t')
    for a in array1[0]:
        print(a, end='\t\t')
    print()
    print('Employee2', end='\t')
    for b in array1[1]:
        print(b, end='\t\t')
    print()
    print('Employee3', end='\t')
    for c in array1[2]:
        print(c, end='\t\t')
    print()
    print()
    print(f'Employee1 worked most hours on {findIndex(array1[0])}')
    print(f'Employee2 worked most hours on {findIndex(array1[1])}')
    print(f'Employee3 worked most hours on {findIndex(array1[2])}')
    print()
    addHours(array1)


main()
