input_string = input()

strength = 0

final_string = ""

for char in input_string:
    if char == ">":
        final_string += ">"
    elif char.isdigit():
        strength += int(char)
        if strength > 0:
            strength -= 1
            continue
        else:
            final_string += char
    else:
        if strength > 0:
            strength -= 1
            continue
        final_string += char


print(final_string)