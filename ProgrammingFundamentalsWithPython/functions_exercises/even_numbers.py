def filter_even_numbers(numbers: list) -> list:
    return list(filter(lambda x: x % 2 == 0, numbers))

list_of_numbers = input().split()

new_list_of_numbers = list(map(int, list_of_numbers))

result = filter_even_numbers(new_list_of_numbers)

print(result)