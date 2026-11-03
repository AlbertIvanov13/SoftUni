import re


places = input()

pattern = r"([=|\/])([A-Za-z]+)\1"

valid_destination = re.findall(pattern, places, re.IGNORECASE)

destinations = []
travel_points = 0

for destination in valid_destination:
    if len(destination[1]) >= 3 and destination[1][0].isupper() and destination[1][:].isalpha():
        destinations.append(destination[1])
        travel_points += len(destination[1])

print(f"Destinations: {', '.join(destinations)}")
print(f"Travel Points: {travel_points}")