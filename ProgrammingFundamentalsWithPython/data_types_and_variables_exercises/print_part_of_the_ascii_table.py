start_index = int(input())
end_index = int(input())

for i in range(start_index, end_index + 1):
    if i == end_index:
        print(chr(i), end="")
    else:
        print(chr(i), end=" ")