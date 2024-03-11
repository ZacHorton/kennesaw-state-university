import random


class Counter:
    def __init__(self, value):
        self.value = value

    def increment(self):
        self.value += 1

    def getValue(self):
        return self.value


def main():
    heads = Counter(0)
    tails = Counter(0)
    for x in range(1, 101):
        print(f'Toss #{x}')
        toss = random.randint(1, 2)
        if toss == 1:
            heads.increment()
        elif toss == 2:
            tails.increment()
        print('Heads:', heads.getValue())
        print('Tails:', tails.getValue())
        print()


main()