gifts = input().split()

command = input()

new_command = ""

new_list = []

while command != "No Money":
    new_command = command.split()

    if new_command[0] == "OutOfStock":
        for gift in range(len(gifts)):
            if gifts[gift] == new_command[1]:
                gifts[gift] = None
    elif new_command[0] == "Required":
            if (int(new_command[2]) > 0)  and (int(new_command[2]) < len(gifts)):
                gifts[int(new_command[2])] = new_command[1]
    elif new_command[0] == "JustInCase":
            gifts[-1] = new_command[1]

    command = input()

for gift in gifts:
    if gift is not None:
        new_list.append(gift)

print(str.join(" ", new_list))