week = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday']
x = int(input('Please input an integer representing which day of the week today is:\nSunday = 0\n'
              'Monday = 1\nTuesday = 2\nWednesday = 3\nThursday = 4\nFriday = 5\nSaturday = 6 '))
next_meeting = int(input('Please input another integer for the number of days until the next meeting. '))

if next_meeting < 6:
    meeting_day = week[x + next_meeting]
elif next_meeting > 6:




# while next_meeting > 7
#     next_meeting -= 7
# if next_meeting == 7:
#     meeting_day = week[x]
# elif next_meeting == 6:
#     meeting_day = week[x-1]
# elif next_meeting == 5:
#     meeting_day = week[x-2]
# elif next_meeting == 4:
#     meeting_day = week[x-3]
# elif next_meeting == 3:
#     meeting_day = week[x-2]
# elif next_meeting == 2:
#     meeting_day = week[x-3]
# elif next_meeting == 1:
#     meeting_day = week[x-4]
#
# print('Today is ', week[x])
# print('Days to the meeting is', days, 'days')
# print('Meeting day is ', meeting_day)




# if next_meeting == 1:
#     meeting_day = week[0]
# elif next_meeting == 2:
#     meeting_day = week[1]
# elif next_meeting == 3:
#     meeting_day = week[2]
# elif next_meeting == 4:
#     meeting_day = week[3]
# elif next_meeting == 5:
#     meeting_day = week[4]
# elif next_meeting == 6:
#     meeting_day = week[5]
# elif next_meeting == 7:
#     meeting_day = week[6]
# print('Today is ', week[x])
# print('Days to the meeting is', y, 'days')
# print('Meeting day is ', meeting_day)