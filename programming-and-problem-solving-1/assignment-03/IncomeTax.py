income = int(input('Please input your annual income. '))
tier0 = income * .05
tier1 = .05 * 50000
tier2 = .10 * 150000
tier3 = .15 * 200000
tier4 = .25 * 500000
tier5 = .35 * 100000
if income <= 50000:
    print('Annual Income:  ', '${:,}'.format(income))
    print('Tax Bracket:     5%')
    print('Tax due amount: ', '${:}'.format(int(tier0)))
elif 50000 < income <= 200000:
    print('Annual Income:  ', '${:,}'.format(income))
    print('Tax Bracket:     10%')
    print('Tax due amount: ', '${:}'.format(int(tier1 + (income - 50000) * .1)))
elif 200000 < income <= 400000:
    print('Annual Income:  ', '${:,}'.format(income))
    print('Tax Bracket:     15%')
    print('Tax due amount: ', '${:}'.format(int(tier1 + tier2 + (income - 200000) * .15)))
elif 400000 < income <= 900000:
    print('Annual Income:  ', '${:,}'.format(income))
    print('Tax Bracket:     25%')
    print('Tax due amount: ', '${:}'.format(int(tier1 + tier2 + tier3 + (income - 400000) * .25)))
elif 900000 < income:
    print('Annual Income:  ', '${:,}'.format(income))
    print('Tax Bracket:     35%')
    print('Tax due amount: ', '${:}'.format(int(tier1 + tier2 + tier3 + tier4 + (income - 900000) * .35)))
