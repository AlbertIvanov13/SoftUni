count_of_lines = int(input())

table_set = set()

for _ in range(count_of_lines):
    elements = input().split()

    for element in elements:
        table_set.add(element)

print(*table_set, sep='\n')