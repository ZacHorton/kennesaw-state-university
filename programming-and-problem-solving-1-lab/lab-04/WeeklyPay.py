hours = float(input('Please enter number of hours worked for a given week. '))
reg = hours * 10
ot = 0
if hours > 40:
    reg = 400
if hours - 40 > 0:
    ot = (hours - 40) * 15
gross = reg + ot
print('You entered', int(hours), 'hours.')
print(f'Gross earning is ${gross}')
