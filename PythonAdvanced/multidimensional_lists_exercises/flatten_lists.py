user_input = input().split("|")

temp = []

for items in range(len(user_input) - 1, -1, -1):
    new_items = user_input[items].split(" ")
    for item in range(len(new_items)):
        if new_items[item] == "":
            continue
        temp.append(new_items[item])


print(*temp)