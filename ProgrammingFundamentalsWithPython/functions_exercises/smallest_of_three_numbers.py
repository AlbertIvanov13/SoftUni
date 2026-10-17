def smallest_number(first: int, second: int, third: int) -> int:
    numbers = [first, second, third]
    return min(numbers)

first_number = int(input())
second_number = int(input())
third_number = int(input())

print(smallest_number(first_number, second_number, third_number))