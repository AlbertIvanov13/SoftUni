def is_number_perfect(number: int) -> bool:

    sum = 0

    for digit in range(1, number):
        if number % digit == 0:
            sum += digit

    if number == sum:
        return True

    return False

integer_number = int(input())

if is_number_perfect(integer_number):
    print("We have a perfect number!")
else:
    print("It's not so perfect.")