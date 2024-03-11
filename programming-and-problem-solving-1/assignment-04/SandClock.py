star_x = 9
space_x = 0
for x in range(5, 0, -1):
    print(space_x * ' ' + star_x * '*')
    star_x -= 2
    space_x += 1
star_y = 3
space_y = 3
for y in range(1, 5):
    print(space_y * ' ' + star_y * '*')
    star_y += 2
    space_y -= 1
