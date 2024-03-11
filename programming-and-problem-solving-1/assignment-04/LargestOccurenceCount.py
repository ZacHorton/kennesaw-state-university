x = []
num = int
while num != 0:
    num = int(input('Please enter positive non zero integer values. '))
    x.append(num)
largest = max(x)
times = x.count(largest)
print('Enter positive integers (0 to quit): ', end='')
print(' '.join(map(str, x)))
print('Largest Value:', largest)
print('Occurrences:  ', times, 'times')
