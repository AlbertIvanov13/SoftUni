import os

file = os.path.join("text.txt")

with open(file) as f:
    i = 0
    for line in f:
        for char in ["-", ",", ".", "!", "?"]:
            if char in line:
                line = line.replace(char, "@")
        final_string = list(reversed(line.split()))
        if i % 2 == 0:
            print(*final_string)
        i += 1