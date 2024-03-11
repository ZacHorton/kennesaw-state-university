def count(array):
    from collections import Counter
    x = Counter(array)
    for k, v in x.items():
        print(f'{k} occurred {v} times.')


def main():
    array_values = input('Please input 10 integers separated by a space. ')
    array1 = list(map(int, array_values.split()))
    print('Entered integers:\t', *array1)
    print()
    count(array1)


main()
