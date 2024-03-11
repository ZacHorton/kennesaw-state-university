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
    print('Employee#\tWeekly Hours')
    print('----------------------------')
    print('1\t\t\t', total1)
    print('2\t\t\t', total2)
    print('3\t\t\t', total3)


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
    addHours(array1)


main()
