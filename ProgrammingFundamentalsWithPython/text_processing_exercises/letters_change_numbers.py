input_string = input().split()

total_sum = 0

for string in range(len(input_string)):
    number = ""
    for char in input_string[string]:
        if char.isdigit():
            number += char
    if input_string[string][0].isupper():
        second_number = ord(input_string[string][0])
        result = int(number) / (second_number - 64)
    else:
        second_number = ord(input_string[string][0])
        result = int(number) * (second_number - 96)

    if input_string[string][-1].isupper():
        second_number = ord(input_string[string][-1])
        result -= second_number - 64
    else:
        second_number = ord(input_string[string][-1])
        result += second_number - 96
    total_sum += result

print(f"{total_sum:.2f}")