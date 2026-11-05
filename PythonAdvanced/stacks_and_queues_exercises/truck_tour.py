from collections import deque

pumps_count = int(input())

pumps = deque()

for _ in range(pumps_count):
    fuel, distance = [int(x) for x in  input().split()]
    pumps.append({"fuel": fuel, "distance": distance})

starting_position = 0
stops = 0

while stops < pumps_count:
    current_fuel = 0
    for i in range(pumps_count):
        current_fuel += pumps[i]["fuel"]
        distance = pumps[i]["distance"]
        if current_fuel < distance:
            stops = 0
            pumps.rotate(-1)
            starting_position += 1
            break
        current_fuel -= distance
        stops += 1

print(starting_position)