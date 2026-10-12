command = input()

while command != "Welcome!":

    if command == "Voldemort":
        print("You must not speak of that name!")
        break

    if len(command) < 5:
        print(f"{command} goes to Gryffindor.")
        command = input()
    elif len(command) == 5:
        print(f"{command} goes to Slytherin.")
        command = input()
    elif len(command) == 6:
        print(f"{command} goes to Ravenclaw.")
        command = input()
    elif len(command) > 6:
        print(f"{command} goes to Hufflepuff.")
        command = input()
else:
    print("Welcome to Hogwarts.")