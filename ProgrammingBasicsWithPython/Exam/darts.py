player_name = input()

starting_points = 301
successful_shots = 0
unsuccessful_shots = 0

while True:
    command = input()

    if command == 'Retire':
        print(f"{player_name} retired after {unsuccessful_shots} unsuccessful shots.")
        break

    points = int(input())

    if command == "Single":
        if points > starting_points:
            unsuccessful_shots += 1
            continue

        elif points <= starting_points:
            starting_points -= points
            successful_shots += 1

    elif command == "Double":
        if points * 2 > starting_points:
            unsuccessful_shots += 1
            continue

        elif points * 2 <= starting_points:
            starting_points -= points * 2
            successful_shots += 1

    elif command == "Triple":
        if points * 3 > starting_points:
            unsuccessful_shots += 1
            continue

        elif points * 3 <= starting_points:
            starting_points -= points * 3
            successful_shots += 1

    if starting_points == 0:
        print(f"{player_name} won the leg with {successful_shots} shots.")
        break
