number_of_usernames = int(input())

set_of_usernames = set()

for i in range(number_of_usernames):

    username = input()
    set_of_usernames.add(username)

for username in set_of_usernames:
    print(username)