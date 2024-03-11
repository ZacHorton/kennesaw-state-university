def printGrades(grade):
    if grade >= 90 and grade <= 100:
        letter = 'A'
    elif grade >= 80 and grade <= 89:
        letter = 'B'
    elif grade >= 70 and grade <= 79:
        letter = 'C'
    elif grade >= 60 and grade <= 69:
        letter = 'D'
    else:
        letter = 'F'
    return letter


def main():
    size = int(input('Please input the class size. '))
    grades = []
    for element in range(0, size):
        grade = int(input('Please enter a valid integer score (between 0 and 100) for each students '))
        if grade >= 0 and grade <=100:
            grades.append(grade)
    print('Class size:      ', size)
    print('Entered grades:', end='   ')
    print(*grades, sep=', ')
    print()
    counter = 0
    while counter != size:
        print(f'Student {counter} score is {grades[counter]} and grade is {printGrades(grades[counter])}')
        counter += 1


main()