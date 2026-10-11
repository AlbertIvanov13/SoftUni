command = input()

word = ""

while command != "End":

    if command == "SoftUni":
        command = input()
        continue

    for i in command:
        word += i
        word += i

    print(f"{word}")
    command = input()
    word = ""