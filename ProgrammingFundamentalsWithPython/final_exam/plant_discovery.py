number = int(input())

plants = {}

for _ in range(number):

    plant_information = input().split("<->")
    plant = plant_information[0]
    rarity = plant_information[1]

    if plant not in plants:
        plants[plant] = {"rarity": rarity, "ratings": []}
    else:
        plants[plant] = {"rarity": rarity}

command = input()

while command != "Exhibition":

    command = command.split(": ")

    if command[0] == "Rate":
        new_plant = command[1].split(" - ")
        if new_plant[0] not in plants:
            print("error")
        else:
            plants[new_plant[0]]["ratings"].append(int(new_plant[1]))
    elif command[0] == "Update":
        new_plant = command[1].split(" - ")
        if new_plant[0] not in plants:
            print("error")
        else:
            plants[new_plant[0]]["rarity"] = int(new_plant[1])
    elif command[0] == "Reset":
        new_plant = command[1].split(" - ")
        if new_plant[0] not in plants:
            print("error")
        else:
            plants[new_plant[0]]["ratings"] = []

    command = input()

print("Plants for the exhibition:")
for current_plant, values in plants.items():
    plant_name = current_plant
    current_rarity = values["rarity"]
    ratings = values["ratings"]
    if len(ratings) > 0:
        print(f"- {plant_name}; Rarity: {current_rarity}; Rating: {sum(ratings) / len(ratings):.2f}")
    else:
        print(f"- {plant_name}; Rarity: {current_rarity}; Rating: {0:.2f}")