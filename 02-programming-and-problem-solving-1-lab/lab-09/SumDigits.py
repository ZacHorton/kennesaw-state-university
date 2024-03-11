def sumDigits(int_number):
    total = 0
    while int_number > 0:
        y = int_number % 10
        total += y
        int_number //= 10
    return total


def main():
    x = int(input('Please input an integer. '))
    print('You entered:  ', x)
    print('Sum of digits:', sumDigits(x))


main()