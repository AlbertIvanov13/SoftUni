phonebook = {}

new_entry = input()

while "-" in new_entry:

    name, phone = new_entry.split("-")

    if name in phonebook.keys():
        phonebook[name] = phone
    else:
        phonebook[name] = phone

    new_entry = input()

number = int(new_entry)

for i in range(number):
    name = input()

    if name in phonebook.keys():
        print(f"{name} -> {phonebook[name]}")
    else:
        print(f"Contact {name} does not exist.")