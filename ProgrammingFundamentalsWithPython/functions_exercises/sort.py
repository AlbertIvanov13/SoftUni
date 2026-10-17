def sorting_function(numbers: list) -> list:

    return list(sorted(numbers))

list_of_numbers = input().split()

new_list_of_numbers = list(map(int, list_of_numbers))

result = sorting_function(new_list_of_numbers)

print(result)