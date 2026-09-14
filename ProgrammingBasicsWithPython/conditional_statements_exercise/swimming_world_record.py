import math

record = float(input())
distance = float(input())
swim_per_meter = float(input())

time = distance * swim_per_meter
increased_time = distance // 15 * 12.5

time += increased_time

if time < record:
    print(f"Yes, he succeeded! The new world record is {time:.2f} seconds.")
else:
    print(f"No, he failed! He was {time - record:.2f} seconds slower.")