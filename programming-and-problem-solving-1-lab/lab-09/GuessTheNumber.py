def random():
    import random
    random_int = random.randint(1, 20)
    return random_int


def firstGuess():
    guess = int(input('Please guess a number between 1 and 20 inclusive. '))
    return guess


def guessCheck(x, y):
    if x == y:
        return 'Correct!'
    elif x > y:
        return "Guess was too low."
    elif x < y:
        return "Guess was too high."


def play_again():
    again = str(input("Do you want to play again? Please enter 'y' for yes or 'n' for no. "))
    if again == 'y':
        main()


def main():
    random_num = random()
    first_guess = firstGuess()
    if guessCheck(random_num, first_guess) != 'Correct!':
        print(guessCheck(random_num, first_guess))  # If not correct, print too low or too high
        next_guess = int(input('Please guess again between 1 and 20 inclusive. '))
        if guessCheck(random_num, next_guess) == 'Correct!':
            print(guessCheck(random_num, next_guess))
        while guessCheck(random_num, next_guess) != 'Correct!':
            print(guessCheck(random_num, next_guess))  # If not correct, print too low or too high
            next_guess = int(input('Please guess again between 1 and 20 inclusive. '))
            if guessCheck(random_num, next_guess) == 'Correct!':
                print(guessCheck(random_num, next_guess))
    else:
        print(guessCheck(random_num, first_guess))  # Will print correct
    play_again()


main()