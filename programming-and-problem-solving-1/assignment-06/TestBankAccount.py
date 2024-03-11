class BankAccount:
    def __init__(self, account_id, balance, annualInterestRate, dateCreated):
        self.account_id = account_id
        self.balance = balance
        self.annualInterestRate = annualInterestRate
        self.dateCreated = dateCreated

    def getMonthlyInterestRate(self):
        monthlyInterestRate = self.annualInterestRate / 12
        return monthlyInterestRate

    def getMonthlyInterest(self, monthlyInterestRate):
        monthlyInterest = self.balance * monthlyInterestRate
        return monthlyInterest  # earned monthly interest amount

    def withdraw(self):
        withdraw = float(input('How much do you wish to withdraw? '))
        self.balance -= withdraw

    def deposit(self):
        deposit = float(input('How much do you wish to deposit? '))
        self.balance += deposit

    def toString(self):
        print('Account ID:\t\t', self.account_id)
        print('Account Balance:\t', '${:,.2f}'.format(self.balance))
        print('Interest Rate:\t\t', '{:.2%}'.format(self.annualInterestRate))
        print('Date Opened:\t\t', self.dateCreated)


def main():
    myObject = BankAccount(123456, 10000, .025, 'Sun Oct 28 09:30:05 EDT 2018')
    myObject.toString()
    print()
    myObject.withdraw()
    myObject.deposit()
    print()
    print('Account Balance:\t\t', '${:,.2f}'.format(myObject.balance))
    print('Earned Monthly Interest:\t', '${:,.2f}'.format(myObject.getMonthlyInterest(myObject.getMonthlyInterestRate())))
    print('Date Opened:\t\t\t', myObject.dateCreated)


main()
