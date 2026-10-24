string = input()

occurrences = {}

for char in string:
    if char == " ":
        continue

    if char not in occurrences.keys():
        occurrences[char] = 1
    else:
        occurrences[char] += 1

for key, value in occurrences.items():
    print(f"{key} -> {value}")