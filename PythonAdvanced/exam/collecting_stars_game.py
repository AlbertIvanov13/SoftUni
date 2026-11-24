n = int(input())

matrix = []

p_row, p_col = 0, 0
last_row, last_col = 0, 0

stars = 2

for _ in range(n):
    matrix.append(input().split())

for row in range(n):
    for col in range(n):
        if matrix[row][col] == "P":
            p_row = row
            p_col = col
            matrix[row][col] = "."

is_teleported = False

while True:
    command = input()

    if command == "up":
        if p_row - 1 < 0:
            last_row = p_row
            last_col = p_col
            matrix[p_row][p_col] = "."
            p_row = 0
            p_col = 0
        else:
            p_row -= 1
        if matrix[p_row][p_col] == "#":
            stars -= 1
            if is_teleported:
                p_row, p_col = last_row, last_col
            else:
                p_row += 1
            if stars == 0:
                print("Game over! You are out of any stars.")
                break
        elif matrix[p_row][p_col] == "*":
            matrix[p_row][p_col] = "."
            stars += 1
            if stars == 10:
                print("You won! You have collected 10 stars.")
                break
    elif command == "down":
        if p_row + 1 > len(matrix) - 1:
            last_row = p_row
            last_col = p_col
            matrix[p_row][p_col] = "."
            p_row = 0
            p_col = 0
        else:
            p_row += 1
        if matrix[p_row][p_col] == "#":
            stars -= 1
            if is_teleported:
                p_row, p_col = last_row, last_col
            else:
                p_row -= 1
            if stars == 0:
                print("Game over! You are out of any stars.")
                break
        elif matrix[p_row][p_col] == "*":
            matrix[p_row][p_col] = "."
            stars += 1
            if stars == 10:
                print("You won! You have collected 10 stars.")
                break
    elif command == "left":
        if p_col - 1 < 0:
            last_row = p_row
            last_col = p_col
            matrix[p_row][p_col] = "."
            p_row = 0
            p_col = 0
        else:
            p_col -= 1
        if matrix[p_row][p_col] == "#":
            stars -= 1
            if is_teleported:
                p_row, p_col = last_row, last_col
            else:
                p_col += 1
            if stars == 0:
                print("Game over! You are out of any stars.")
                break
        elif matrix[p_row][p_col] == "*":
            matrix[p_row][p_col] = "."
            stars += 1
            if stars == 10:
                print("You won! You have collected 10 stars.")
                break
    elif command == "right":
        if p_col + 1 > len(matrix) - 1:
            last_row = p_row
            last_col = p_col
            matrix[p_row][p_col] = "."
            p_row = 0
            p_col = 0
        else:
            p_col += 1
        if matrix[p_row][p_col] == "#":
            stars -= 1
            if is_teleported:
                p_row, p_col = last_row, last_col
            else:
                p_col -= 1
            if stars == 0:
                print("Game over! You are out of any stars.")
                break
        elif matrix[p_row][p_col] == "*":
            matrix[p_row][p_col] = "."
            stars += 1
            if stars == 10:
                print("You won! You have collected 10 stars.")
                break

matrix[p_row][p_col] = "P"
print(f"Your final position is [{p_row}, {p_col}]")
for row in range(n):
    print(*matrix[row])