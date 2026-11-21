file = open("text.txt")

file_to_write = open("output.txt", "w")

with file as f, file_to_write as f2:
    for index, line in enumerate(f):
        letters = [x for x in line if x.isalpha()]
        others = [x for x in line if not x.isalpha() and not x in [" ", "\n"]]
        f2.write(f"Line {index + 1}: {line.strip()} ({len(letters)})({len(others)})\n")