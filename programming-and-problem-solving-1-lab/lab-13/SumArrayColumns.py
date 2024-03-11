def sumColumn(matrix, index):
    summed = ([sum(x) for x in zip(*matrix)])
    return summed[index]


def main():
    print('Please enter a 3-by-4 array. ')
    row1 = [int(x) for x in input().split()]
    row2 = [int(x) for x in input().split()]
    row3 = [int(x) for x in input().split()]
    matrix = [row1, row2, row3]
    print('The entered matrix:')
    print('\n'.join([''.join(['{:4}'.format(element) for element in row])
                     for row in matrix]))
    print('Sum of column 0 is', sumColumn(matrix, 0))
    print('Sum of column 1 is', sumColumn(matrix, 1))
    print('Sum of column 2 is', sumColumn(matrix, 2))
    print('Sum of column 3 is', sumColumn(matrix, 3))


main()
