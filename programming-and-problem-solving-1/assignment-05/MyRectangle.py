width = int(input('Please enter the width of a rectangle. '))
height = int(input('Please enter the height of a rectangle. '))


def isValid():
    valid_sum = width + height
    if valid_sum > 30:
        return True
    else:
        print('Entered width: ', width)
        print('Entered height:', height)
        print('This is invalid rectangle. Try again.')
        quit()


def Area():
    area = width * height
    return area


def Perimeter():
    perimeter = width * 2 + height * 2
    return perimeter


def main():
    isValid()
    print('Entered width: ', width)
    print('Entered height:', height)
    print('Area:          ', Area())
    print('Perimeter:     ', Perimeter())


main()