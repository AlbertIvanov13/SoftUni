first_player = input()
second_player = input()

first_player_points = 0
second_player_points = 0

while True:
    command = input()

    if command == "End of game":
        print(f"{first_player} has {first_player_points} points")
        print(f"{second_player} has {second_player_points} points")
        break

    first_player_card = int(command)
    second_player_card = int(input())

    if first_player_card > second_player_card:
        first_player_points += first_player_card - second_player_card

    elif second_player_card > first_player_card:
        second_player_points += second_player_card - first_player_card

    else:
        print(f"Number wars!")
        first_player_card = int(input())
        second_player_card = int(input())

        if first_player_card > second_player_card:
            # first_player_points += first_player_card - second_player_card
            print(f"{first_player} is winner with {first_player_points} points")
            break
        elif second_player_card > first_player_card:
            # second_player_points += second_player_card - first_player_card
            print(f"{second_player} is winner with {second_player_points} points")
            break