class PasswordTooShortError(Exception):
    pass

class PasswordTooCommonError(Exception):
    pass

class PasswordNoSpecialCharacterError(Exception):
    pass

class PasswordContainsSpacesError(Exception):
    pass

is_valid = True

while True:
    password = input()
    if password == "Done":
        break

    if len(password) < 8:
        is_valid = False
        raise PasswordTooShortError("Password must contain at least 8 characters")

    if password.isalpha() or password.isdigit() or all(not char.isdigit() and not char.isalpha() for char in password):
        is_valid = False
        raise PasswordTooCommonError("Password must be a combination of digits, letters, and special characters")

    if  not(password.count("@") >= 1 or password.count("*") >= 1 or password.count("&") >= 1 or password.count("%") >= 1):
        is_valid = False
        raise PasswordNoSpecialCharacterError("Password must contain at least 1 special character")

    if " " in password:
        is_valid = False
        raise PasswordContainsSpacesError("Password must not contain empty spaces")

    if is_valid:
        print("Password is valid")