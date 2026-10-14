working_day_events = input().split("|")

initial_energy = 100
initial_coins = 100

is_closed = False

gained_energy = 0

for day in working_day_events:
    event_or_ingredient = day.split("-")

    if event_or_ingredient[0] == "rest":
        if int(event_or_ingredient[1]) > 100:
            print(f"You gained {0} energy.")
        else:
            if initial_energy + int(event_or_ingredient[1]) <= 100:
                initial_energy += int(event_or_ingredient[1])
                print(f"You gained {int(event_or_ingredient[1])} energy.")
                print(f"Current energy: {initial_energy}.")
            else:
                if gained_energy + 100 - initial_energy <= 100:
                    gained_energy += 100 - initial_energy
                    print(f"You gained {gained_energy} energy.")
                    print(f"Current energy: {100}.")
                    initial_energy += gained_energy
                else:
                    print(f"You gained {0} energy.")
                    print(f"Current energy: {100}.")
    elif event_or_ingredient[0] == "order":
        if initial_energy - 30 >= 0:
            initial_coins += int(event_or_ingredient[1])
            initial_energy -= 30
            print(f"You earned {int(event_or_ingredient[1])} coins.")
        else:
            initial_energy += 50
            print(f"You had to rest!")
    else:
        if initial_coins >= int(event_or_ingredient[1]):
            initial_coins -= int(event_or_ingredient[1])
            print(f"You bought {event_or_ingredient[0]}.")
        else:
            print(f"Closed! Cannot afford {event_or_ingredient[0]}.")
            is_closed = True
            break

if not is_closed:
    print("Day completed!")
    print(f"Coins: {initial_coins}")
    print(f"Energy: {initial_energy}")