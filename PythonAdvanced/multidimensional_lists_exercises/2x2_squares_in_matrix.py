rows, cols = map(int, input().split())

matrix = []

count_of_equal_cells = 0

for _ in range(rows):
    matrix.append(input().split())

for row in range(rows - 1):
    for col in range(cols - 1):
        if ((matrix[row][col] == matrix[row][col + 1])
                and (matrix[row + 1][col] == matrix[row][col])
                and (matrix[row + 1][col + 1] == matrix[row][col])):
            count_of_equal_cells += 1

print(count_of_equal_cells)