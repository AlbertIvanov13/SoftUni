text = input()

set_of_strings = set(text)

final_strings = {}

for char in text:
    if char not in final_strings:
        final_strings[char] = 1
    else:
        final_strings[char] += 1

for key, value in sorted(final_strings.items()):
    print(f"{key}: {value} time/s")