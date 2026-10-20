def positive_numbers(list_of_integers: list) -> list:
    result = [number for number in list_of_integers if int(number) >= 0]

    return result

def negative_numbers(list_of_integers: list) -> list:
    result = [number for number in list_of_integers if int(number) < 0]

    return result

def even_numbers(list_of_integers: list) -> list:
    result = [number for number in list_of_integers if int(number) % 2 == 0]

    return result

def odd_numbers(list_of_integers: list) -> list:
    result = [number for number in list_of_integers if int(number) % 2 != 0]

    return result

numbers = input().split(", ")

print(f"Positive: {', '.join(positive_numbers(numbers))}")
print(f"Negative: {', '.join(negative_numbers(numbers))}")
print(f"Even: {', '.join(even_numbers(numbers))}")
print(f"Odd: {', '.join(odd_numbers(numbers))}")