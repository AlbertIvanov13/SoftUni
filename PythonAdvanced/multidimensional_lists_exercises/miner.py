n = int(input())
commands = input().split()

matrix = []
miner_row, miner_col = 0, 0
coal = 0

for row in range(n):
    matrix.append(input().split())
    for col in range(n):
        if matrix[row][col] == "s":
            miner_row, miner_col = row, col
        elif matrix[row][col] == "c":
            coal += 1

commands_map = {
    "up": lambda r, c: (r - 1, c) if r - 1 >= 0 else (r, c),
    "down": lambda r, c: (r + 1, c) if r + 1 < n else (r, c),
    "left": lambda r, c: (r, c - 1) if c - 1 >= 0 else (r, c),
    "right": lambda r, c: (r, c + 1) if c + 1 < n else (r, c),
}

for command in commands:
    miner_row, miner_col = commands_map[command](miner_row, miner_col)

    if matrix[miner_row][miner_col] == "e":
        print(f"Game over! ({miner_row}, {miner_col})")
        break
    elif matrix[miner_row][miner_col] == "c":
        coal -= 1
        matrix[miner_row][miner_col] = "*"
        if coal == 0:
            print(f"You collected all coal! ({miner_row}, {miner_col})")
            break
else:
    print(f"{coal} pieces of coal left. ({miner_row}, {miner_col})")