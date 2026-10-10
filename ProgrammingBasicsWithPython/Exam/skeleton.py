minutes = int(input())
seconds = int(input())
length = float(input())
seconds_for_hundred = int(input())

total_seconds = minutes * 60 + seconds
time_for_passing_hundred = length / 100 * seconds_for_hundred

total_time = length / 120 * 2.5

time_for_passing_hundred -= total_time

if time_for_passing_hundred <= total_seconds:
    print(f"Marin Bangiev won an Olympic quota!")
    print(f"His time is {time_for_passing_hundred:.3f}.")
else:
    print(f"No, Marin failed! He was {time_for_passing_hundred - total_seconds:.3f} second slower.")