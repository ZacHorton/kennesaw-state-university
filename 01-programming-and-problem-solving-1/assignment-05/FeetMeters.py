def feetToMeter():
    print('Feet', end='\t')
    print('Meter')
    for x in range(1, 10):
        print(float(x), end='\t')
        print(.305 * x)
    for y in range(10, 21):
        print(float(y), end='\t')
        print(.305 * y)


def meterToFeet():
    print('Meter', end='\t')
    print('Feet')
    for x in range(1, 10):
        print(float(x), end='\t')
        print(3.279 * x)
    for y in range(10, 21):
        print(float(y), end='\t')
        print(3.279 * y)


def main():
    feetToMeter()
    print()
    meterToFeet()


main()