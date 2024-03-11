class Stock:
    def __init__(self, Symbol, Name, previousClosingPrice, currentPrice):
        self.Symbol = Symbol
        self.Name = Name
        self.previousClosingPrice = previousClosingPrice
        self.currentPrice = currentPrice

    def getName(self):
        return self.Name

    def getSymbol(self):
        return self.Symbol

    def setClosingPrice(self):
        return self.setClosingPrice()

    def setCurrentPrice(self):
        return self.setCurrentPrice()

    def getChangePercent(self):
        percent = (-(self.previousClosingPrice - self.currentPrice) / self.previousClosingPrice * 100)
        return percent

    def toString(self):
        return f"{self.Name} stock's closing price is ${self.previousClosingPrice}"


def main():
    google = Stock('GOG', 'Google', 134.67, 131.98)
    print(f'{google.Name} stock:', )
    print('\tSymbol:', google.Symbol)
    print('\tClosing Price:  ', google.previousClosingPrice)
    print('\tCurrent price:  ', google.currentPrice)
    print(f'\tChange percent: {round(google.getChangePercent())}%')
    print(f'\t{google.Name} stock closing price is ${google.currentPrice}')
    print()
    microsoft = Stock('MSF', 'Microsoft', 156.52, 161.22)
    print(f'{microsoft.Name} stock:', )
    print('\tSymbol:', microsoft.Symbol)
    print('\tClosing Price:  ', microsoft.previousClosingPrice)
    print('\tCurrent price:  ', microsoft.currentPrice)
    print(f'\tChange percent:  {round(microsoft.getChangePercent())}%')
    print(f'\t{microsoft.Name} stock closing price is ${microsoft.currentPrice}')


main()
