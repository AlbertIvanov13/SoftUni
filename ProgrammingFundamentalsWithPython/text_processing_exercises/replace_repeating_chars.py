input_string = input()

text = ""

for char in range(len(input_string)):
    if char - 1 < 0:
        text += input_string[char]
    elif char + 1 >= len(input_string) and input_string[char] != input_string[char - 1]:
        text += input_string[char]
    else:
        if input_string[char] != input_string[char - 1]:
            text += input_string[char]

print(text)