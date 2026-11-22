size_of_matrix = int(input())

bee_row, bee_col = 0, 0

matrix = []

total_energy = 15

total_nectar = 0

for _ in range(size_of_matrix):
    matrix.append(list(input()))

for r in range(size_of_matrix):
    for c in range(size_of_matrix):
        if matrix[r][c] == "B":
            bee_row = r
            bee_col = c

is_restored = False

while True:
    command = input()

    if command == "up":
        total_energy -= 1
        if bee_row - 1 < 0:
            matrix[bee_row][bee_col] = "-"
            bee_row = len(matrix) - 1
        else:
            matrix[bee_row][bee_col] = "-"
            bee_row -= 1
        if matrix[bee_row][bee_col].isdigit():
            total_nectar += int(matrix[bee_row][bee_col])
            matrix[bee_row][bee_col] = "-"
        elif matrix[bee_row][bee_col] == "H":
            if total_nectar >= 30:
                print(f"Great job, Beesy! The hive is full. Energy left: {total_energy}")
                break
            else:
                print("Beesy did not manage to collect enough nectar.")
                break
        if total_energy <= 0 and total_nectar < 30:
            print("This is the end! Beesy ran out of energy.")
            break
        elif total_energy <= 0 and total_nectar >= 30:
            if not is_restored:
                total_energy += total_nectar - 30
                total_nectar = 30
                if total_energy == 0:
                    print("This is the end! Beesy ran out of energy.")
                    break
                else:
                    is_restored = True
            else:
                print("This is the end! Beesy ran out of energy.")
                break
    elif command == "down":
        total_energy -= 1
        if bee_row + 1 > len(matrix) - 1:
            matrix[bee_row][bee_col] = "-"
            bee_row = 0
        else:
            matrix[bee_row][bee_col] = "-"
            bee_row += 1
        if matrix[bee_row][bee_col].isdigit():
            total_nectar += int(matrix[bee_row][bee_col])
            matrix[bee_row][bee_col] = "-"
        elif matrix[bee_row][bee_col] == "H":
            if total_nectar >= 30:
                print(f"Great job, Beesy! The hive is full. Energy left: {total_energy}")
                break
            else:
                print("Beesy did not manage to collect enough nectar.")
                break
        if total_energy <= 0 and total_nectar < 30:
            print("This is the end! Beesy ran out of energy.")
            break
        elif total_energy <= 0 and total_nectar >= 30:
            if not is_restored:
                total_energy += total_nectar - 30
                total_nectar = 30
                if total_energy == 0:
                    print("This is the end! Beesy ran out of energy.")
                    break
                else:
                    is_restored = True
            else:
                print("This is the end! Beesy ran out of energy.")
                break
    elif command == "left":
        total_energy -= 1
        if bee_col - 1 < 0:
            matrix[bee_row][bee_col] = "-"
            bee_col = len(matrix) - 1
        else:
            matrix[bee_row][bee_col] = "-"
            bee_col -= 1
        if matrix[bee_row][bee_col].isdigit():
            total_nectar += int(matrix[bee_row][bee_col])
            matrix[bee_row][bee_col] = "-"
        elif matrix[bee_row][bee_col] == "H":
            if total_nectar >= 30:
                print(f"Great job, Beesy! The hive is full. Energy left: {total_energy}")
                break
            else:
                print("Beesy did not manage to collect enough nectar.")
                break
        if total_energy <= 0 and total_nectar < 30:
            print("This is the end! Beesy ran out of energy.")
            break
        elif total_energy <= 0 and total_nectar >= 30:
            if not is_restored:
                total_energy += total_nectar - 30
                total_nectar = 30
                if total_energy == 0:
                    print("This is the end! Beesy ran out of energy.")
                    break
                else:
                    is_restored = True
            else:
                print("This is the end! Beesy ran out of energy.")
                break
    elif command == "right":
        total_energy -= 1
        if bee_col + 1 > len(matrix) - 1:
            matrix[bee_row][bee_col] = "-"
            bee_col = 0
        else:
            matrix[bee_row][bee_col] = "-"
            bee_col += 1
        if matrix[bee_row][bee_col].isdigit():
            total_nectar += int(matrix[bee_row][bee_col])
            matrix[bee_row][bee_col] = "-"
        elif matrix[bee_row][bee_col] == "H":
            if total_nectar >= 30:
                print(f"Great job, Beesy! The hive is full. Energy left: {total_energy}")
                break
            else:
                print("Beesy did not manage to collect enough nectar.")
                break
        if total_energy <= 0 and total_nectar < 30:
            print("This is the end! Beesy ran out of energy.")
            break
        elif total_energy <= 0 and total_nectar >= 30:
            if not is_restored:
                total_energy += total_nectar - 30
                total_nectar = 30
                if total_energy == 0:
                    print("This is the end! Beesy ran out of energy.")
                    break
                else:
                    is_restored = True
            else:
                print("This is the end! Beesy ran out of energy.")
                break


matrix[bee_row][bee_col] = "B"
for row in range(size_of_matrix):
    print("".join(matrix[row]))