divisor = int(input())
boundary = int(input())

largest_number = 0

for i in range(1, boundary + 1):
    if i % divisor == 0 and i <= boundary and i > 0:

        if i > largest_number:
            largest_number = i

print(largest_number)