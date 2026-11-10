import sys

rows, cols = map(int, input().split())

matrix = []

maximal_sum = -sys.maxsize

final_matrix = []

for _ in range(rows):
    matrix.append(list(map(int, input().split())))

for row in range(rows - 2):
    for col in range(cols - 2):
        max_sum = (matrix[row][col]
                        + matrix[row][col + 1]
                        + matrix[row][col + 2]
                        + matrix[row + 1][col]
                        + matrix[row + 1][col + 1]
                        + matrix[row + 1][col + 2]
                        + matrix[row + 2][col]
                        + matrix[row + 2][col + 1]
                        + matrix[row + 2][col + 2])
        if max_sum > maximal_sum:
            maximal_sum = max_sum
            final_matrix = [[matrix[row][col], matrix[row][col + 1], matrix[row][col + 2]],
                            [matrix[row + 1][col], matrix[row + 1][col + 1], matrix[row + 1][col + 2]],
                            [matrix[row + 2][col], matrix[row + 2][col + 1], matrix[row + 2][col + 2]]]


print(f"Sum = {maximal_sum}")
for i in range(3):
    print(' '.join(map(str, final_matrix[i])))