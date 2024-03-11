while True:
    height = int(input('Please enter your height in inches. '))
    weight = int(input('Please enter your weight in pounds. '))
    age = int(input('Please enter your age. '))
    gender = str(input("Please enter your gender: Input either 'Male' or 'Female' "))
    bmr = float
    if gender == 'Male':
        bmr = 66 + (6.23 * weight) + (12.7 * height) - (6.8 * age)
    elif gender == 'Female':
        bmr = 655 + (4.35 * weight) + (4.7 * height) - (4.7 * age)
    else:
        print("You did not input 'Male' or 'Female' ")
        break
    level = int(input("Please select your approximate level of exercise each week from the options below: \n1. You "
                      "don't exercise \n2. You engage in light exercise one to three days a week \n3. You exercise"
                      " moderately three to five times a week \n4. You exercise intensely six to seven days a week \n"
                      "5. You exercise intensely six to seven days a week and have a physically active job "))
    dca = float
    if level == 1:
        dca = bmr * 1.2
    elif level == 2:
        dca = bmr * 1.375
    elif level == 3:
        dca = bmr * 1.55
    elif level == 4:
        dca = bmr * 1.725
    elif level == 5:
        dca = bmr * 1.9
    else:
        print('You did not input a number from 1 to 5. ')
        break
    print(f'{gender}, {height}", {weight} lbs, age {age}, BMR = {round(bmr, 2)}, Exercise {level}, DCA: {round(dca, 2)}')
    break
