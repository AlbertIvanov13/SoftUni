def sum_numbers(first: int, second: int) -> int:
    return first + second

def subtract(first: int, second: int, third: int) -> int:
    return sum_numbers(first, second) - third

def add_and_subtract(first: int, second: int, third: int) -> int:
    return subtract(first, second, third)


first_number = int(input())
second_number = int(input())
third_number = int(input())

result = add_and_subtract(first_number, second_number, third_number)
print(result)