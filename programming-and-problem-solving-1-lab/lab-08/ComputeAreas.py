def squareArea(side):
    print('Square side:     ', side)
    print('Square area:     ', round(side * side, 2))


def rectangleArea(width, length):
    area = width * length
    print('Rectangle width: ', width)
    print('Rectangle length:', length)
    print('Rectangle area:  ', area)


def circleArea(radius):
    area = 3.14 * (radius * radius)
    print('Circle radius:   ', radius)
    print('Circle area:     ', area)


def triangleArea(base, height):
    area = (base / 2) * height
    print('Triangle base:   ', base)
    print('Triangle height: ', height)
    print('Triangle area:   ', round(area, 2))


def main():
    a = float(input('Enter the side of a square. '))
    b = float(input('Enter the width of a rectangle. '))
    c = float(input('Enter the length of a rectangle. '))
    d = float(input('Enter the radius of a circle. '))
    e = float(input('Enter the base of a triangle. '))
    f = float(input('Enter the height of a triangle. '))
    print()
    squareArea(a)
    print()
    rectangleArea(b, c)
    print()
    circleArea(d)
    print()
    triangleArea(e, f)


main()