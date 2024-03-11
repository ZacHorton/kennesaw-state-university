def isEquivalent(array1, array2):
    new_list1 = []
    for row in array1:
        for col in row:
            new_list1.append(col)
    new_list2 = []
    for row in array2:
        for col in row:
            new_list2.append(col)
    from collections import Counter
    if Counter(new_list1) == Counter(new_list2):
        return 'The arrays are equivalent. '
    else:
        return 'The arrays are not equivalent. '


def main():
    print('Create a 3x3 array')
    first = input('Please enter the first row, separating each value with a space. ')
    first_split = list(map(int, first.split()))
    second = input('Please enter the second row, separating each value with a space. ')
    second_split = list(map(int, second.split()))
    third = input('Please enter the third row, separating each value with a space. ')
    third_split = list(map(int, third.split()))
    array1 = [first_split, second_split, third_split]
    print('Create another 3x3 array')
    fourth = input('Please enter the first row, separating each value with a space. ')
    fourth_split = list(map(int, fourth.split()))
    fifth = input('Please enter the second row, separating each value with a space. ')
    fifth_split = list(map(int, fifth.split()))
    sixth = input('Please enter the third row, separating each value with a space. ')
    sixth_split = list(map(int, sixth.split()))
    array2 = [fourth_split, fifth_split, sixth_split]
    print('Array A:')
    print('\t', *first_split)
    print('\t', *second_split)
    print('\t', *third_split)
    print()
    print('Array B:')
    print('\t', *fourth_split)
    print('\t', *fifth_split)
    print('\t', *sixth_split)
    print()
    print('Judgment:', isEquivalent(array1, array2))


main()
