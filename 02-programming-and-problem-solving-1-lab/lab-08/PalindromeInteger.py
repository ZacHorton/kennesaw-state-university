def reverse(number):
    new_number = 0
    while number > 0:
        end_digit = number % 10
        new_number = (new_number * 10) + end_digit
        number //= 10
    return new_number


def isPalindrome(judgment):
    print('Entered value: ', judgment)
    if judgment == reverse(judgment):
        print('Judgment:       Palindrome')
    else:
        print('Judgment:       Not palindrome')


def main():
    a = int(input('Enter an integer value. '))
    isPalindrome(a)


main()