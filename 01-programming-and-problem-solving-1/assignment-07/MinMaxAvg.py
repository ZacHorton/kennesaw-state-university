def minMaxAvg(array):
    highest = max(map(max, array))
    lowest = min(map(min, array))
    average = round(sum(map(sum, array)) / 16, 2)
    print('Highest grade:\t', highest)
    print('Lowest grade:\t', lowest)
    print('Class average:\t', average)


def main():
    import random
    x = [[random.randint(0, 100) for a in range(4)] for b in range(4)]
    print('Array Grades:')
    for c in range(len(x)):
        for d in range(len(x[c])):
            print('\t', x[c][d], end='\t')
        print()
    print()
    minMaxAvg(x)


main()
