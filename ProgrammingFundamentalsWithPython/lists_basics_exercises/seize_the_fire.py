cells = input().split("#")
amount_of_water = int(input())

effort = 0
total_fire = 0

put_out_cells = []

for cell in cells:
    new_cell = cell.split(" = ")

    if new_cell[0] == "High":
        if int(new_cell[1]) < 81 or int(new_cell[1]) > 125:
            continue
        else:
            if amount_of_water >= int(new_cell[1]):
                amount_of_water -= int(new_cell[1])
                effort += int(new_cell[1]) * 0.25
                put_out_cells.append(new_cell[1])
            else:
                continue
    elif new_cell[0] == "Medium":
        if int(new_cell[1]) < 51 or int(new_cell[1]) > 80:
            continue
        else:
            if amount_of_water >= int(new_cell[1]):
                amount_of_water -= int(new_cell[1])
                effort += int(new_cell[1]) * 0.25
                put_out_cells.append(new_cell[1])
            else:
                continue
    elif new_cell[0] == "Low":
        if int(new_cell[1]) < 1 or int(new_cell[1]) > 50:
            continue
        else:
            if amount_of_water >= int(new_cell[1]):
                amount_of_water -= int(new_cell[1])
                effort += int(new_cell[1]) * 0.25
                put_out_cells.append(new_cell[1])
            else:
                continue

print("Cells:")
for cell in put_out_cells:
    print(f" - {cell}")
    total_fire += int(cell)


print(f"Effort: {effort:.2f}")
print(f"Total Fire: {total_fire}")