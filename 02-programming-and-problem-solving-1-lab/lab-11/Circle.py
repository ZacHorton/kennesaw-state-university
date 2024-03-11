class Circle:
    def __init__(self, radius):
        self.radius = radius

    def getRadius(self):
        return self.radius

    def setRadius(self, radius):
        self.radius = radius
        return self.radius

    def getArea(self):
        area = 3.14 * (self.radius ** 2)
        return area

    def getPerimeter(self):
        perimeter = 2 * 3.14 * self.radius
        return perimeter

    def toString(self):
        return f'The circle has radius {self.radius}.\tWhere {self.radius} is the value of variable radius'

def main():
    circle = Circle(1)
    print('Print radius:')
    print(f'\tThe radius is {circle.radius}.')
    print()
    print('Print area:')
    print('\tThe area is', "{0:.2f}".format(circle.getArea()))
    print()
    print('Print perimeter:')
    print('\tThe perimeter is', "{0:.2f}".format(circle.getPerimeter()))
    print()
    print('Set radius to 10 and print the object:')
    circle.setRadius(10)
    print(f'\tThe circle has radius {circle.radius}.')
    print()
    print('Print area:')
    print('\tThe area is', "{0:.2f}".format(circle.getArea()))
    print()
    print('Print perimeter:')
    print('\tThe perimeter is', "{0:.2f}".format(circle.getPerimeter()))


main()
