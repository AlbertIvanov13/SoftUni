number = int(input())

queries = []

final_stack = []

for _ in range(number):
    query = input()
    if query[0] == "1":
        query = query.split()
        new_number = int(query[1])
        queries.append(new_number)
    elif query == "2":
        if len(queries) > 0:
            queries.pop()
    elif query == "3":
        if len(queries) > 0:
            print(max(queries))
    elif query == "4":
        if len(queries) > 0:
            print(min(queries))

while queries:
    final_stack.append(str(queries.pop()))

print(", ".join(final_stack))