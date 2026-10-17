def is_number_a_palindrome(number: int) -> bool:

        reversed_number = str(number)[::-1]

        if int(reversed_number) == number:
            return True

        return False

list_of_numbers = input().split(", ")

for number in list_of_numbers:

    checked_number = int(number)
    print(is_number_a_palindrome(checked_number))