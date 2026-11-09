n = int(input())

matrix = []

primary_sum = 0
secondary_sum = 0

for row in range(n):
    matrix.append(list(map(int, input().split())))
    primary_sum += matrix[row][row]
    secondary_sum += matrix[row][-1 - row]

print(abs(primary_sum - secondary_sum))