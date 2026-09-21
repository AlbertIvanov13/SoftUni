import math

pages_count = int(input())
pages_per_hour = int(input())
days_to_read = int(input())

needed_hours = math.floor(pages_count / (pages_per_hour * days_to_read))

print(needed_hours)