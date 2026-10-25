parking_lot = {}

number_of_commands = int(input())

for _ in range(number_of_commands):

    command = input().split()

    if command[0] == "register":
        username = command[1]
        license_plate_number = command[2]

        if username not in parking_lot.keys():
            parking_lot[username] = license_plate_number
            print(f"{username} registered {license_plate_number} successfully")
        else:
            print(f"ERROR: already registered with plate number {license_plate_number}")
    elif command[0] == "unregister":
        username = command[1]

        if username not in parking_lot.keys():
            print(f"ERROR: user {username} not found")
        else:
            del parking_lot[username]

            print(f"{username} unregistered successfully")

for user, license_number in parking_lot.items():
    print(f"{user} => {license_number}")