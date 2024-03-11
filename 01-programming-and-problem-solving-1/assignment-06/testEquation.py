import math


class QuadraticEquation:
    def __init__(self, a, b, c):
        self.a = a
        self.b = b
        self.c = c

    def getDiscriminant(self):
        self.disc = (self.b ** 2) - 4 * (self.a * self.c)
        return self.disc

    def getRoot1(self, disc):
        self.R1 = ((-self.b + math.sqrt(disc)) / (2 * self.a))
        return self.R1

    def getRoot2(self, disc):
        self.R2 = ((-self.b - math.sqrt(disc)) / (2 * self.a))
        return self.R2


def testEquation():
    p1 = QuadraticEquation(3, 8, 4)
    disc1 = p1.getDiscriminant()
    print('Sample run 1 for 3(x^2) + 8x + 4')
    print('a =', p1.a)
    print('b -', p1.b)
    print('c =', p1.c)
    if disc1 >= 0:
        print('Root 1 =', p1.getRoot1(disc1))
        print('Root 2 =', p1.getRoot2(disc1))
    else:
        print('Root 1 is Undefined')
        print('Root 2 is Undefined')
    print()
    p2 = QuadraticEquation(3, 4, 8)
    disc2 = p2.getDiscriminant()
    print('Sample run 2 for 3(x^2) + 4x + 8')
    print('a =', p2.a)
    print('b -', p2.b)
    print('c =', p2.c)
    if disc2 >= 0:
        print('Root 1 =', p2.getRoot1(disc2))
        print('Root 2 =', p2.getRoot2(disc2))
    else:
        print('Root 1 is Undefined')
        print('Root 2 is Undefined')
    print()
    p3 = QuadraticEquation(2, 8, 2)
    disc3 = p3.getDiscriminant()
    print('Sample run 3 for 2(x^2) + 8x + 2')
    print('a =', p3.a)
    print('b -', p3.b)
    print('c =', p3.c)
    if disc3 >= 0:
        print('Root 1 =', p3.getRoot1(disc3))
        print('Root 2 =', p3.getRoot2(disc3))
    else:
        print('Root 1 is Undefined')
        print('Root 2 is Undefined')


testEquation()
