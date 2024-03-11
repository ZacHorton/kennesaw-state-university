class Rectangle:
    def __init__(self, height, width):
        self.height = height
        self.width = width

    def getHeight(self):
        self.height = int(input('What is the height of the rectangle? '))
        return self.height

    def getWidth(self):
        self.width = int(input('What is the width of the rectangle? '))
        print()
        return self.width

    def getArea(self):
        area = self.height * self.width
        return area

    def getPerimeter(self):
        perimeter = (self.height * 2) + (self.width * 2)
        return perimeter


def main():
    r1 = Rectangle(1, 1)
    print('First Object:')
    print('\tHeight:    ', r1.height, 'unit')
    print('\tWidth:     ', r1.width, 'unit')
    print('\tArea:      ', r1.getArea(), 'units')
    print('\tPerimeter: ', r1.getPerimeter(), 'units')
    print()
    r2 = Rectangle(5, 6)
    print('Second Object:')
    print('\tHeight:    ', r2.height, 'unit')
    print('\tWidth:     ', r2.width, 'unit')
    print('\tArea:      ', r2.getArea(), 'units')
    print('\tPerimeter: ', r2.getPerimeter(), 'units')
    print()
    r3 = Rectangle(0, 0)  # Exercise #1 Line 3
    r3.height = r3.getHeight()  # Exercise #1 Line 3
    r3.width = r3.getWidth()  # Exercise #1 Line 3
    print('User-Specified Height and Width:')  # Exercise #1 Line 3
    print('\tHeight:    ', r3.height, 'unit')  # Exercise #1 Line 3
    print('\tWidth:     ', r3.width, 'unit')  # Exercise #1 Line 3
    print('\tArea:      ', r3.getArea(), 'units')  # Exercise #1 Line 3
    print('\tPerimeter: ', r3.getPerimeter(), 'units')  # Exercise #1 Line 3


main()
