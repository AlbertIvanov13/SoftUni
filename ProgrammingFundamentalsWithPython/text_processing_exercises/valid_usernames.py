def has_valid_length(name: str) -> bool:
    if 3 <= len(name) <= 16:
        return True
    return False

def containing_chars(name: str) -> bool:
    for char in name:
        if char.isdigit() or char.isalpha() or char == "_" or char == "-":
            continue
        else:
            return False
    else:
        return True

def has_valid_username(name: str) -> bool:
    if has_valid_length(name) and containing_chars(name):
        return True
    return False

usernames = input().split(", ")

for username in usernames:
    if has_valid_username(username):
        print(username)