customers_count = int(input())

training_back_count = 0
training_chest_count = 0
training_legs_count = 0
training_abs_count = 0
protein_shake_buyers = 0
protein_bar_buyers = 0

training_people = 0
buyers = 0

for _ in range(customers_count):
    activity_type = input()

    if activity_type == "Back":
        training_back_count += 1
        training_people += 1

    elif activity_type == "Chest":
        training_chest_count += 1
        training_people += 1

    elif activity_type == "Legs":
        training_legs_count += 1
        training_people += 1

    elif activity_type == "Abs":
        training_abs_count += 1
        training_people += 1

    elif activity_type == "Protein shake":
        protein_shake_buyers += 1
        buyers += 1

    elif activity_type == "Protein bar":
        protein_bar_buyers += 1
        buyers += 1

print(f"{training_back_count} - back")
print(f"{training_chest_count} - chest")
print(f"{training_legs_count} - legs")
print(f"{training_abs_count} - abs")
print(f"{protein_shake_buyers} - protein shake")
print(f"{protein_bar_buyers} - protein bar")
print(f"{training_people / customers_count * 100:.2f}% - work out")
print(f"{buyers / customers_count * 100:.2f}% - protein")
