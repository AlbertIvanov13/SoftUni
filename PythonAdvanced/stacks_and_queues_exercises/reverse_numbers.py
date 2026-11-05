numbers = input().split()

reversed_numbers = []

for number in range(len(numbers)):
    reversed_numbers.append(numbers.pop())

print(" ".join(reversed_numbers))