x = int(input('Please enter the x-coordinate. '))
y = int(input('Please enter the y-coordinate. '))
if x == 0 and y == 0:
    print('X-coordinate is', x)
    print('Y-coordinate is', y)
    print('(0,0) is the origin point.')
elif x != 0 and y == 0:
    print('X-coordinate is', x)
    print('Y-coordinate is', y)
    print('(', x, ',0) is on the x-axis.')
elif x == 0 and y != 0:
    print('X-coordinate is', x)
    print('Y-coordinate is', y)
    print('0,', y, ') is on the y-axis.')
elif x > 0 and y > 0:
    print('X-coordinate is', x)
    print('Y-coordinate is', y)
    print('(', x, ',', y, ') is in the first quadrant.')
elif x < 0 and y > 0:
    print('X-coordinate is', x)
    print('Y-coordinate is', y)
    print('(', x, ',', y, ') is in the second quadrant.')
elif x < 0 and y < 0:
    print('X-coordinate is', x)
    print('Y-coordinate is', y)
    print('(', x, ',', y, ') is in the third quadrant.')
elif x > 0 and y < 0:
    print('X-coordinate is', x)
    print('Y-coordinate is', y)
    print('(', x, ',', y, ') is in the fourth quadrant.')
