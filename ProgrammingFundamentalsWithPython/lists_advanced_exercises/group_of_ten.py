sequence_of_numbers = input().split(", ")

group = 10

while sequence_of_numbers:
    lis_of_numbers = [int(number) for number in sequence_of_numbers if int(number) <= group]
    for num in lis_of_numbers:
        sequence_of_numbers.remove(str(num))
    print(f"Group of {group}'s: {lis_of_numbers}")

    group += 10