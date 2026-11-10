rows = int(input())

matrix = []

for row in range(rows):
    line = [int(x) for x in input().split()]
    matrix.append(line)

command = input().split()

while command[0] != "END":
    if command[0] == "Add":
        row = int(command[1])
        col = int(command[2])
        value = int(command[3])
        if (row >= 0 and row <= rows - 1) and (col >= 0 and col <= rows - 1):
            matrix[row][col] += value
        else:
            print("Invalid coordinates")
    elif command[0] == "Subtract":
        row = int(command[1])
        col = int(command[2])
        value = int(command[3])
        if (row >= 0 and row <= rows - 1) and (col >= 0 and col <= rows - 1):
            matrix[row][col] -= value
        else:
            print("Invalid coordinates")

    command = input().split()

for row in range(rows):
    print(*matrix[row])