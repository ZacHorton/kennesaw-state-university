def in_order(start_ord, end_ord):
    if start_ord == end_ord:
        return 'start and end characters are the same. Try again.'
    elif start_ord < end_ord:
        return True
    else:
        return 'start and end characters are out of order. Try again.'


def printChar(start_ord, end_ord):
    counter = 0
    while start_ord <= end_ord:
        print(chr(start_ord), end=' ')
        start_ord += 1
        counter += 1
        if counter % 5 == 0:
            print('\r')


def main():
    start_ord = ord(input('Please input starting character. '))
    start_chr = chr(start_ord)
    end_ord = ord(input('Please input ending character. '))
    end_chr = chr(end_ord)
    if in_order(start_ord, end_ord) == True:
        print('Start character:', start_chr)
        print('End character:  ', end_chr)
        print('Output:')
        printChar(start_ord, end_ord)
    else:
        print('Start character:', start_chr)
        print('End character:  ', end_chr)
        print('Output:', in_order(start_ord, end_ord))


main()


