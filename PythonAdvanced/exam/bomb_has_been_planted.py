rows, cols = map(int, input().split(", "))

matrix = []

total_seconds = 16

c_r, c_c = 0, 0

init_r, init_c = 0, 0

for r in range(rows):
    matrix.append(list(input()))
    for c in range(len(matrix[r])):
        if matrix[r][c] == "C":
            c_r, c_c = r, c
            init_r, init_c = r, c

ready_to_defuse = False

while True:
    command = input()

    if command == "left":
        total_seconds -= 1
        if c_c - 1 < 0:
            c_c = 0
            continue
        c_c -= 1
        if total_seconds == 0:
            print("Terrorists win!")
            print("Bomb was not defused successfully!")
            print(f"Time needed: {0} second/s.")
            break
        if matrix[c_r][c_c] == "B":
            continue
        elif matrix[c_r][c_c] == "T":
            matrix[c_r][c_c] = "*"
            print("Terrorists win!")
            break
    elif command == "right":
        total_seconds -= 1
        if c_c + 1 > len(matrix[0]) - 1:
            c_c = len(matrix[0]) - 1
            continue
        c_c += 1
        if total_seconds == 0:
            print("Terrorists win!")
            print("Bomb was not defused successfully!")
            print(f"Time needed: {0} second/s.")
            break
        if matrix[c_r][c_c] == "B":
            continue
        elif matrix[c_r][c_c] == "T":
            matrix[c_r][c_c] = "*"
            print("Terrorists win!")
            break
    elif command == "up":
        total_seconds -= 1
        if c_r - 1 < 0:
            c_r = 0
            continue
        c_r -= 1
        if total_seconds == 0:
            print("Terrorists win!")
            print("Bomb was not defused successfully!")
            print(f"Time needed: {0} second/s.")
            break
        if matrix[c_r][c_c] == "B":
            continue
        elif matrix[c_r][c_c] == "T":
            matrix[c_r][c_c] = "*"
            print("Terrorists win!")
            break
    elif command == "down":
        total_seconds -= 1
        if c_r + 1 > len(matrix) - 1:
            c_r = len(matrix) - 1
            continue
        c_r += 1
        if total_seconds == 0:
            print("Terrorists win!")
            print("Bomb was not defused successfully!")
            print(f"Time needed: {0} second/s.")
            break
        if matrix[c_r][c_c] == "B":
            continue
        elif matrix[c_r][c_c] == "T":
            matrix[c_r][c_c] = "*"
            print("Terrorists win!")
            break
    elif command == "defuse":
        if matrix[c_r][c_c] != "B":
            total_seconds -= 2
            if total_seconds == 0:
                print("Terrorists win!")
                print("Bomb was not defused successfully!")
                print(f"Time needed: {0} second/s.")
                break
            continue
        if total_seconds - 4 >= 0:
            total_seconds -= 4
            matrix[c_r][c_c] = "D"
            print("Counter-terrorist wins!")
            print(f"Bomb has been defused: {total_seconds} second/s remaining.")
            break
        else:
            matrix[c_r][c_c] = "X"
            print("Terrorists win!")
            print("Bomb was not defused successfully!")
            print(f"Time needed: {4 - total_seconds} second/s.")
            break

matrix[init_r][init_c] = "C"
for r in range(len(matrix)):
    print(''.join(map(str, matrix[r])))