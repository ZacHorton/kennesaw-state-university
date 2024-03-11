def displaySums():
    i = int(input('Please enter an integer value. '))
    print('i', end='\t')
    print('Sum(i)')
    total = 0
    for x in range(1, i+1):
        row = x / (x + 1)
        print(x, end='\t')
        total += row
        print(round(total, 4))


displaySums()
