while True:
    space = [' ']
    my_list = [1, 2, 3, 4, 5, 6]
    for x in range(6):
        print(*my_list)
        my_list.pop()
        my_list = space + my_list
    break
