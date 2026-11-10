n = int(input())

matrix = [[int (x) for x in input().split(", ")] for _ in range(n)]

primary_diagonal = []
secondary_diagonal = []

col = -1

for row in range(len(matrix)):
    primary_diagonal.append(int(matrix[row][row]))
    secondary_diagonal.append(int(matrix[row][col]))
    col -= 1

print(f"Primary diagonal: {', '.join(map(str, primary_diagonal))}. Sum: {sum(primary_diagonal)}")
print(f"Secondary diagonal: {', '.join(map(str, secondary_diagonal))}. Sum: {sum(secondary_diagonal)}")