strings_count = int(input())

for _ in range(strings_count):
    current_string = input()
    for string in current_string:
        if string == "," or string == "." or string == "_":
            print(f"{current_string} is not pure!")
            break
    else:
        print(f"{current_string} is pure.")
        continue