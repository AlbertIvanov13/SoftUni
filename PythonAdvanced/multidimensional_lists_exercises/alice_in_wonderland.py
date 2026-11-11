n = int(input())
matrix = []

alice_row = 0
alice_col = 0

for row in range(n):
    current_row = input().split()
    matrix.append(current_row)

    if 'A' in current_row:
        alice_row = row
        alice_col = current_row.index('A')

directions = {
    'up': (-1, 0),
    'down': (1, 0),
    'left': (0, -1),
    'right': (0, 1)
}

tea_bags = 0

matrix[alice_row][alice_col] = '*'

while tea_bags < 10:
    command = input()
    row_change, col_change = directions[command]
    alice_row += row_change
    alice_col += col_change

    if alice_row < 0 or alice_row >= n or alice_col < 0 or alice_col >= n:
        print("Alice didn't make it to the tea party.")
        break

    current_cell = matrix[alice_row][alice_col]
    matrix[alice_row][alice_col] = '*'
    if current_cell == 'R':
        print("Alice didn't make it to the tea party.")
        break
    if current_cell.isdigit():
        tea_bags += int(current_cell)
else:
    print("She did it! She went to the party.")

for row in matrix:
    print(' '.join(row))