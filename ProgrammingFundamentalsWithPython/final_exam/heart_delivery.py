neighborhood = list(map(int, input().split("@")))

command = input()

last_position_index = 0

while command != "Love!":

    command = command.split()

    length = int(command[1])

    if last_position_index + length >= len(neighborhood):
        last_position_index = 0
        length = 0

    if neighborhood[length + last_position_index] == 0:
        print(f"Place {last_position_index + length} already had Valentine's day.")
    else:
        neighborhood[length + last_position_index] -= 2
        if neighborhood[length + last_position_index] == 0:
            print(f"Place {length + last_position_index} has Valentine's day.")

    last_position_index += length

    command = input()

print(f"Cupid's last position was {last_position_index}.")
houseCount = 0
for house in neighborhood:
    if house > 0:
        houseCount += 1
if houseCount > 0:
    print(f"Cupid has failed {houseCount} places.")
else:
    print(f"Mission was successful.")