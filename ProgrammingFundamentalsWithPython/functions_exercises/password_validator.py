def validate_password_length(password: str) -> bool:
    if len(password) < 6 or len(password) > 10:
        return False

    return True

def validate_password_letters_and_digits(password: str) -> bool:
    for char in password:
        if not char.isdigit() and not char.isalpha():
            return False

    return True

def validate_password_digits_count(password: str) -> bool:
    count_of_digits = 0

    for char in password:
        if char.isdigit():
            count_of_digits += 1

    if count_of_digits < 2:
        return False

    return True

check_password = input()

if not validate_password_length(check_password):
    print("Password must be between 6 and 10 characters")
if not validate_password_letters_and_digits(check_password):
    print("Password must consist only of letters and digits")
if not validate_password_digits_count(check_password):
    print("Password must have at least 2 digits")

valid_password_length = validate_password_length(check_password)
valid_password_consistency = validate_password_letters_and_digits(check_password)
valid_password_digits_count = validate_password_digits_count(check_password)

if valid_password_length and valid_password_consistency and valid_password_digits_count:
    print("Password is valid")