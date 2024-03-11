grade1 = int(input('Please enter the first grade. '))
grade2 = int(input('Please enter the second grade. '))
grade3 = int(input('Please enter the third grade. '))
grade4 = int(input('Please enter the fourth grade. '))
average_grade = float((grade1 + grade2 + grade3 + grade4) / 4)
if grade1 >= grade2 and grade1 >= grade3 and grade1 >= grade4:
    highest_grade = grade1
elif grade2 >= grade1 and grade2 >= grade3 and grade2 >= grade4:
    highest_grade = grade2
elif grade3 >= grade1 and grade3 >= grade2 and grade3 >= grade4:
    highest_grade = grade3
else:
    highest_grade = grade4
if grade1 <= grade2 and grade1 <= grade3 and grade1 <= grade4:
    lowest_grade = grade1
elif grade2 <= grade1 and grade2 <= grade3 and grade2 <= grade4:
    lowest_grade = grade2
elif grade3 <= grade1 and grade3 <= grade2 and grade3 <= grade4:
    lowest_grade = grade3
else:
    lowest_grade = grade4
print('You entered:  ', grade1, ',', grade2, ',', grade3, ',', grade4)
print('Highest grade:', highest_grade)
print('Lowest grade: ', lowest_grade)
print('Average grade:', average_grade)
