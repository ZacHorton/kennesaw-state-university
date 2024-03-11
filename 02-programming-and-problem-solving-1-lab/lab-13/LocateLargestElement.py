def locateLargest(matrix):
    largest = 0
    largest_r = 0
    largest_c = 0
    counter_r = -1
    for r in matrix:
        counter_r += 1
        counter_c = -1
        for c in r:
            counter_c += 1
            if c > largest:
                largest = c
                largest_r = counter_r
                largest_c = counter_c
    return largest_r, largest_c


def main():
    print('Please enter a 3-by-4 array. ')
    row1 = [int(x) for x in input().split()]
    row2 = [int(x) for x in input().split()]
    row3 = [int(x) for x in input().split()]
    matrix = [row1, row2, row3]
    print('The entered matrix:')
    print('\n'.join([''.join(['{:4}'.format(element) for element in row])
                     for row in matrix]))
    largest_r, largest_c = locateLargest(matrix)
    print(f'First largest value is located at row {largest_r} and column {largest_c}')


main()
