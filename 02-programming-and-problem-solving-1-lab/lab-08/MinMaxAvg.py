def average(x, y, z):
    avg = (x + y + z) / 3
    return round(avg)


def main():
    x = int(input('Please enter an integer value. '))
    y = int(input('Please enter a second integer value. '))
    z = int(input('Please enter a third integer value. '))
    print(f'You entered:   {x}, {y}, {z}')
    print('Max value:    ', max(x, y, z))
    print('Min value:    ', min(x, y, z))
    print('Average value:', average(x, y, z))


main()