size_of_matrix = int(input())

ship_r, ship_c = 0, 0

matrix = []

units = 100

for r in range(size_of_matrix):
    matrix.append(list(input().split()))

for i in range(size_of_matrix):
    for j in range(size_of_matrix):
        if matrix[i][j] == "S":
            ship_r = i
            ship_c = j
            matrix[i][j] = "."

is_reached = False

while True:
    command = input()

    if command == "up":
        units -= 5
        if ship_r - 1 < 0:
            print("Mission failed! The spaceship was lost in space.")
            break
        else:
            ship_r -= 1
        if matrix[ship_r][ship_c] == "R":
            units += 10
            if units > 100:
                units = 100
        elif matrix[ship_r][ship_c] == "P" and units >= 0:
            is_reached = True
            print(f"Mission accomplished! The spaceship reached Planet B with {units} resources left.")
            break
        elif matrix[ship_r][ship_c] == "M":
            units -= 5
            matrix[ship_r][ship_c] = "."
            if units < 5:
                print("Mission failed! The spaceship was stranded in space.")
                break
        elif units < 5:
            print("Mission failed! The spaceship was stranded in space.")
            break
    elif command == "down":
        units -= 5
        if ship_r + 1 > len(matrix) - 1:
            print("Mission failed! The spaceship was lost in space.")
            break
        else:
            ship_r += 1
        if matrix[ship_r][ship_c] == "R":
            units += 10
            if units > 100:
                units = 100
        elif matrix[ship_r][ship_c] == "P" and units >= 0:
            is_reached = True
            print(f"Mission accomplished! The spaceship reached Planet B with {units} resources left.")
            break
        elif matrix[ship_r][ship_c] == "M":
            units -= 5
            matrix[ship_r][ship_c] = "."
            if units < 5:
                print("Mission failed! The spaceship was stranded in space.")
                break
        elif units < 5:
            print("Mission failed! The spaceship was stranded in space.")
            break
    elif command == "left":
        units -= 5
        if ship_c - 1 < 0:
            print("Mission failed! The spaceship was lost in space.")
            break
        else:
            ship_c -= 1
        if matrix[ship_r][ship_c] == "R":
            units += 10
            if units > 100:
                units = 100
        elif matrix[ship_r][ship_c] == "P" and units >= 0:
            is_reached = True
            print(f"Mission accomplished! The spaceship reached Planet B with {units} resources left.")
            break
        elif matrix[ship_r][ship_c] == "M":
            units -= 5
            matrix[ship_r][ship_c] = "."
            if units < 5:
                print("Mission failed! The spaceship was stranded in space.")
                break
        elif units < 5:
            print("Mission failed! The spaceship was stranded in space.")
            break
    elif command == "right":
        units -= 5
        if ship_c + 1 > len(matrix) - 1:
            print("Mission failed! The spaceship was lost in space.")
            break
        else:
            ship_c += 1
        if matrix[ship_r][ship_c] == "R":
            units += 10
            if units > 100:
                units = 100
        elif matrix[ship_r][ship_c] == "P" and units >= 0:
            is_reached = True
            print(f"Mission accomplished! The spaceship reached Planet B with {units} resources left.")
            break
        elif matrix[ship_r][ship_c] == "M":
            units -= 5
            matrix[ship_r][ship_c] = "."
            if units < 5:
                print("Mission failed! The spaceship was stranded in space.")
                break
        elif units < 5:
            print("Mission failed! The spaceship was stranded in space.")
            break

if not is_reached:
    matrix[ship_r][ship_c] = "S"
for row in range(size_of_matrix):
    print(" ".join(matrix[row]))