import sys

n = int(input())

field = []

bunny_row = 0
bunny_col = 0

for row in range(n):
    current_row = input().split()
    field.append(current_row)
    if 'B' in current_row:
        bunny_row = row
        bunny_col = current_row.index('B')

directions = {
    "up": (-1, 0),
    "down": (1, 0),
    "left": (0, -1),
    "right": (0, 1)
}

best_direction = ''
best_path = []
best_eggs = -sys.maxsize

for direction, movement in directions.items():
    row_change, col_change = movement
    current_row = bunny_row + row_change
    current_col = bunny_col + col_change

    eggs = 0
    path = []

    while 0 <= current_row < n and 0 <= current_col < n:
        if field[current_row][current_col] == 'X':
            break
        eggs += int(field[current_row][current_col])
        path.append([current_row, current_col])
        current_row += row_change
        current_col += col_change

    if path and eggs > best_eggs:
        best_eggs = eggs
        best_direction = direction
        best_path = path

print(best_direction)
for p in best_path:
    print(p)
print(best_eggs)