quantity_of_decorations = int(input())
days_left_until_christmas = int(input())

budget = 0
total_spirit = 0

for day in range(1, days_left_until_christmas + 1):
    if day % 11 == 0:
        quantity_of_decorations += 2

    if day % 2 == 0:
        budget += 2 * quantity_of_decorations
        total_spirit += 5

    if day % 3 == 0:
        budget += 8 * quantity_of_decorations
        total_spirit += 13

    if day % 5 == 0:
        budget += 15 * quantity_of_decorations
        total_spirit += 17

    if day % 15 == 0:
        total_spirit += 30

    if day % 10 == 0:
        total_spirit -= 20
        budget += 23

    if day == days_left_until_christmas and day % 10 == 0:
        total_spirit -= 30

print(f"Total cost: {budget}")
print(f"Total spirit: {total_spirit}")