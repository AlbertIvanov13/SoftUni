encrypted_message = input()

command = input()

while command != "Decode":

    command = command.split("|")

    if command[0] == "Move":
        number_of_letters = int(command[1])
        first_letters = encrypted_message[:number_of_letters]
        encrypted_message = encrypted_message[number_of_letters:] + first_letters
    elif command[0] == "Insert":
        index = int(command[1])
        value = command[2]
        encrypted_message = list(encrypted_message)
        encrypted_message.insert(index, value)
        encrypted_message = "".join(encrypted_message)
    elif command[0] == "ChangeAll":
        substring = command[1]
        replacement = command[2]
        encrypted_message = str(encrypted_message.replace(substring, replacement))

    command = input()

print(f"The decrypted message is: {encrypted_message}")