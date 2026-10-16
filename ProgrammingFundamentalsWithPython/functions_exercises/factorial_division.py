def calculate_factorial(number_one: int, number_two: int) -> int:

    first_sum = 1
    second_sum = 1

    for digit in range(1, number_one + 1):
        first_sum *= digit

    for digit in range(1, number_two + 1):
        second_sum *= digit

    return first_sum // second_sum

first_number = int(input())
second_number = int(input())

result = calculate_factorial(first_number, second_number)

print(f"{result:.2f}")