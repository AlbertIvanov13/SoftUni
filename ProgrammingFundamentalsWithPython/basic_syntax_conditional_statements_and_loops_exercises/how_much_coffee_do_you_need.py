command = input()

coffees = 0

while command != "END":

    if command.isupper():
        if command == "END":
            break
        elif command == "CODING" or command == "DOG" or command == "CAT" or command == "MOVIE":
            coffees += 2
        else:
            command = input()
            continue
    elif command.islower():
        if command == "coding" or command == "dog" or command == "cat" or command == "movie":
            coffees += 1

    command = input()


if coffees > 5:
    print(f"You need extra sleep")
else:
    print(coffees)