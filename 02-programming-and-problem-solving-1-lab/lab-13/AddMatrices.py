def Addition(matrix_a, matrix_b):
    results = [[matrix_a[x][y] + matrix_b[x][y] for y in range(len(matrix_a[0]))] for x in range(len(matrix_a))]
    return results


def main():
    print('Please enter a 3-by-3 array. ')
    row1 = [int(x) for x in input().split()]
    row2 = [int(x) for x in input().split()]
    row3 = [int(x) for x in input().split()]
    matrix_a = [row1, row2, row3]
    print('Please enter another 3-by-3 array. ')
    row4 = [int(x) for x in input().split()]
    row5 = [int(x) for x in input().split()]
    row6 = [int(x) for x in input().split()]
    matrix_b = [row4, row5, row6]
    matrix_c = Addition(matrix_a, matrix_b)
    print('Matrix A:')
    print('\n'.join([''.join(['{:4}'.format(element) for element in row])
                     for row in matrix_a]))
    print()
    print('Matrix B:')
    print('\n'.join([''.join(['{:4}'.format(element) for element in row])
                     for row in matrix_b]))
    print()
    print('A + B:')
    print('\n'.join([''.join(['{:4}'.format(element) for element in row])
                     for row in matrix_c]))


main()
