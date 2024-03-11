test_num = int(input('Please input a 5-digit number.'))
test_num_front = test_num // 1000
test_num_back = test_num % 100
num1 = test_num_front // 10
num2 = test_num_front % 10
num4 = test_num_back // 10
num5 = test_num_back % 10
if 10000 <= test_num <= 99999:
    if num1 == num5 and num2 == num4:
        print('Entered number: ', test_num)
        print('Judgement: Valid 5 digit palindrome')
    else:
        print('Entered number: ', test_num)
        print('judgement: Invalid 5-digit palindrome.')
else:
    print('Entered number: ', test_num)
    print('Judgement: Invalid 5 digit number. Try again.')
