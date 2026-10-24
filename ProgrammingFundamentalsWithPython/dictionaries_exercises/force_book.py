force_sides = {}

users = []

input_line = input()

while input_line != "Lumpawaroo":

    new_line = input_line.split()

    if "|" in new_line:
        new_line = input_line.split(" | ")

        force_side = new_line[0]
        force_user = new_line[1]

        if force_side not in force_sides.keys():
            force_sides[force_side] = []
            if force_user not in users:
                force_sides[force_side].append(force_user)
                users.append(force_user)
            elif force_user in users:
                input_line = input()
                continue
        elif force_user not in users:
            force_sides[force_side].append(force_user)
            users.append(force_user)
    elif "->" in new_line:
        new_line = input_line.split(" -> ")

        force_user = new_line[0]
        force_side = new_line[1]

        if force_side not in force_sides.keys():
            force_sides[force_side] = []
            if force_user not in users:
                force_sides[force_side].append(force_user)

        for users in force_sides.values():
            if force_user in users:
                users.remove(force_user)
                force_sides[force_side].append(force_user)
                break
        else:
            force_sides[force_side].append(force_user)

        print(f"{force_user} joins the {force_side} side!")



    input_line = input()

for side, people in force_sides.items():
    if not people:
        continue
    print(f"Side: {side}, Members: {len(people)}")
    for person in people:
        print(f"! {person}")