lines = int(input())

total_capacity = 255

tank_filled = 0

for _ in range(lines):
    liters_of_water = int(input())

    if tank_filled + liters_of_water <= total_capacity:
        tank_filled += liters_of_water
    else:
        print("Insufficient capacity!")
        continue

print(tank_filled)