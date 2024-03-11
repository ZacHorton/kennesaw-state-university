#  Python does not have a switch-case construct.
grade = int(input("Please enter the student's grade."))
if grade >= 100:
    message = 'That grade is a perfect score. Well done.'
elif grade >= 90 and grade <= 99:
    message = 'That grade is well above average. Excellent work.'
elif grade >= 80 and grade <= 89:
    message = 'That grade is above average. Nice job.'
elif grade >= 70 and grade <= 79:
    message = 'That grade is average work.'
elif grade >= 60 and grade <= 69:
    message = 'That grade is not good, you should seek help!'
else:
    message = 'That grade is not passing.'
print('You entered', grade)
print(message)
