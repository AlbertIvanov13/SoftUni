def min_number(list_of_numbers: list) -> str:
    minimum_number = min(list_of_numbers)
    return f"The minimum number is {minimum_number}"

def max_number(list_of_numbers: list) -> str:
    maximum_number = max(list_of_numbers)
    return f"The maximum number is {maximum_number}"

def sum_all_numbers(list_of_numbers: list) -> str:
    sum_of_numbers = sum(list_of_numbers)
    return f"The sum number is: {sum_of_numbers}"

numbers = input().split()

new_list_of_numbers = list(map(int, numbers))

lowest_number = min_number(new_list_of_numbers)
highest_number = max_number(new_list_of_numbers)
sum_of_all_numbers = sum_all_numbers(new_list_of_numbers)

print(lowest_number)
print(highest_number)
print(sum_of_all_numbers)