rows, cols = map(int, input().split())

start = ord("a")

for row in range(rows):
    for col in range(cols):
        print(f"{chr(start + row)}{chr(start + row + col)}{chr(start + row)}", end=" ")
    print()