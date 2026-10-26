strings = input().split()

total_sum = 0

first_string = strings[0]
second_string = strings[1]

if len(first_string) > len(second_string):
    for char in range(len(first_string)):
        if char < len(second_string):
            total_sum += ord(first_string[char]) * ord(second_string[char])
        else:
            total_sum += ord(first_string[char])
else:
    for char in range(len(second_string)):
        if char < len(first_string):
            total_sum += ord(first_string[char]) * ord(second_string[char])
        else:
            total_sum += ord(second_string[char])

print(total_sum)