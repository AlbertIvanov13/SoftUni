size_of_matrix = int(input())

matrix = []

for row in range(size_of_matrix):
    matrix.append(list(input()))

knight_moves = [
    (-2, -1), (-2, 1), (-1, -2), (-1, 2),
    (1, -2), (1, 2), (2, -1), (2, 1)
]

removed_knights = 0

while True:
    max_attack = 0
    knight_to_remove = None

    for row in range(size_of_matrix):
        for col in range(size_of_matrix):
            if matrix[row][col] == "K":
                attack = 0
                for move_row, move_col in knight_moves:
                    next_row = row + move_row
                    next_col = col + move_col

                    if 0 <= next_row < size_of_matrix and 0 <= next_col < size_of_matrix:
                        if matrix[next_row][next_col] == "K":
                            attack += 1
                if attack > max_attack:
                    max_attack = attack
                    knight_to_remove = [row, col]
    if max_attack == 0:
        break
    row, col = knight_to_remove
    matrix[row][col] = "0"
    removed_knights += 1

print(removed_knights)