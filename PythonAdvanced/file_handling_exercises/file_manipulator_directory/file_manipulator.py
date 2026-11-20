import os

command = input().split("-")

while True:

    if command[0] == "End":
        break

    if command[0] == "Create":
        file_name = command[1]
        open(file_name, "w").close()
    elif command[0] == "Add":
        file_name = command[1]
        content = command[2]
        with open(file_name, "a") as file:
            file.write(content)
            file.write("\n")
    elif command[0] == "Replace":
        file_name = command[1]
        old_string = command[2]
        new_string = command[3]
        if os.path.exists(file_name):
            with open(file_name, "r") as file:
                content = file.read()
            content = content.replace(old_string, new_string)
            with open(file_name, "w") as file:
                file.write(content)
        else:
            print("An error occurred")
    elif command[0] == "Delete":
        file_name = command[1]
        if os.path.exists(file_name):
            os.remove(file_name)
        else:
            print("An error occurred")


    command = input().split("-")