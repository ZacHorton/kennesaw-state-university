def main():
    x = 0
    total = 0
    while x < 30704:
        x += 1
        if tester(x) != None:
            total += 1
            print(tester(x), end='\t')
            if total % 10 == 0:
                print()


def tester(number):
    if isPalindrome(number) == True and isPrime(number) == True:
        return number
    else:
        pass


def isPalindrome(number):
    start_number = number
    new_number = 0
    while number > 0:
        end_digit = number % 10
        new_number = (new_number * 10) + end_digit
        number //= 10
    if start_number == new_number:
        return True
    else:
        return False


def isPrime(number):
    if number > 1:
        for x in range(2, number):
            if (number % x) == 0:
                return False
        else:
            return True
    else:
        return False


main()