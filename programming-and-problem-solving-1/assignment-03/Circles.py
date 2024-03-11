import math
X1 = int(input('Please enter the x-coordinate at the center of the first circle.'))
Y1 = int(input('Please enter the y-coordinate at the center of the first circle.'))
R1 = int(input('Please enter the radius of the first circle.'))
X2 = int(input('Please enter the x-coordinate at the center of the second circle.'))
Y2 = int(input('Please enter the y-coordinate at the center of the second circle.'))
R2 = int(input('Please enter the radius of the second circle.'))
Distance = math.sqrt(((X2 - X1) ** 2) + ((Y2 - Y1) ** 2))
Sum_R = R1 + R2
Judgement = 'none'
if R1 > (Distance + R2):
    Judgement = 'Circle 2 is completely inside Circle 1'
elif Distance > Sum_R:
    Judgement = 'Circle 2 is completely outside Circle 1'
elif Distance <= Sum_R:
    Judgement = 'Circle 2 is overlapping with Circle 1'
print('Circle 1 center is (', X1, ',', Y1, ')')
print('Circle 1 radius is:', R1)
print('Circle 2 center is (', X2, ',', Y2, ')')
print('Circle 2 radius is:', R2)
print('Judgement:', Judgement)
