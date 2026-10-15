factor = int(input())
count = int(input())

list = []

for number in range(1, count + 1):
    list.append(factor * number)

print(list)