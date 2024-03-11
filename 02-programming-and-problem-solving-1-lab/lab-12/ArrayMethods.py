def arrayMax(array):
    return max(array)


def arrayMin(array):
    return min(array)


def arraySquared(array):
    squared = []
    for element in range(0, 5):
        update = array[element] ** 2
        squared.append(update)
    return squared


def arrayReverse(array):
    return list(reversed(array))


def main():
    import random
    x = [random.randint(1, 100), random.randint(1, 100), random.randint(1, 100), random.randint(1, 100),
         random.randint(1, 100)]
    print('Original array:', end='  ')
    print(*x, sep=', ')
    print('Max value:      ', arrayMax(x))
    print('Min value:      ', arrayMin(x))
    print('Squared array:', end='   ')
    print(*arraySquared(x), sep=', ')
    print('Reversed array:', end='  ')
    print(*arrayReverse(x), sep=', ')


main()
