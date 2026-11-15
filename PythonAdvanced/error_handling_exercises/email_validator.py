class NameTooShortError(Exception):
    pass

class MustContainAtSymbolError(Exception):
    pass

class InvalidDomainError(Exception):
    pass

email = input()

is_valid = True

while email != "End":

    if "@" not in email:
        is_valid = False
        raise MustContainAtSymbolError("Email must contain @")
    if len(email[:email.index("@")]) <= 4:
        is_valid = False
        raise NameTooShortError("Name must be more than 4 characters")
    if email[email.index("."):] not in [".com", ".bg", ".org", ".net"]:
        is_valid = False
        raise InvalidDomainError("Domain must be one of the following: .com, .bg, .org, .net")

    if is_valid:
        print("Email is valid")

    email = input()