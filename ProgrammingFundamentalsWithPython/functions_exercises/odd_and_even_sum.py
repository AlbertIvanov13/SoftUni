def sum_of_even_and_odd(number: int) -> str:
    odd_sum = 0
    even_sum = 0

    for digit in str(number):
        if int(digit) % 2 == 0:
            even_sum += int(digit)
        else:
            odd_sum += int(digit)

    return f"Odd sum = {odd_sum}, Even sum = {even_sum}"

num = int(input())

result = sum_of_even_and_odd(num)
print(result)