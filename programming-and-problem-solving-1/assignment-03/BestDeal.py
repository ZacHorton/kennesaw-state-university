small_weight = int(input('How many pounds does the small box weigh? '))
small_price = int(input('How many dollars does the small box cost? '))
large_weight = int(input('How many pounds does the large box weigh? '))
large_price = int(input('How many dollars does the large box cost? '))
small_value = small_weight / small_price
large_value = large_weight / large_price
if small_value > large_value:
    judgement = 'The smaller box is a better deal.'
elif small_value < large_value:
    judgement = 'The large box is a better deal.'
else:
    judgement = 'Both boxes are of the same value.'
print('Small box weight: ', small_weight, 'Pounds')
print('Small box price: ', small_price, 'Dollars')
print('Large box weight: ', large_weight, 'Pounds')
print('Large box price: ', large_price, 'Dollars')
print('Judgement: ', judgement)
