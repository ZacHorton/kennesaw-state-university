account_num = input('Please enter your Account Number. ')
input_value = input("Enter 'R' for Regular Service Type or 'P' for Premium Service Type ")
reg_amount_due = 0
prem_amount_due = 0
if input_value == 'R':
    input_type = 'Regular'
    reg_minutes = int(input('Please enter total number of minutes that the service was used.'))
    if reg_minutes > 0:
        reg_amount_due += 15  # $15 for the first 50 minutes
    if reg_minutes > 50:
        reg_amount_due += (reg_minutes - 50) * .5  # $0.50 per minute after the first 50 minutes
    print('Account Number: ', account_num)
    print('Service type: ', input_type)
    print('Total minutes: ', reg_minutes)
    print('Amount due: ', '${:,.2f}'.format(reg_amount_due))
elif input_value == 'P':
    input_type = 'Premium'
    prem_minutes_day = int(input('Please enter total number of minutes that the service was used during '
                                 'the daytime (between 6:00AM to 6:00PM).)'))
    if prem_minutes_day > 50:
        prem_amount_due += ((prem_minutes_day - 50) * .2)  # First 50 minutes are free and .20 per minute after
    prem_minutes_night = int(input('Please enter total number of minutes that the service was used during '
                                   'the nighttime (between 6:00PM to 6:00AM).)'))
    if prem_minutes_night > 100:
        prem_amount_due += ((prem_minutes_night - 100) * .1)  # first 100 minutes are free and .10 oer minute after
    prem_amount_due += 25  # $25 flat fee for premium service
    print('Account Number: ', account_num)
    print('Service type: ', input_type)
    print('Daytime minutes: ', prem_minutes_day)
    print('Nighttime minutes', + prem_minutes_night)
    print('Amount due: ', '${:,.2f}'.format(prem_amount_due))
else:
    print("You did not enter an 'R' for Regular Service or 'P' for Premium Service.")
