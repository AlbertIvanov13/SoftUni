numbers = input().split(", ")
beggars_count = int(input())

beggar_list = []

for beggar in range(beggars_count):
    beggar_list.append(0)

while any(numbers):
    for beg in range(beggars_count):
        for num in numbers:
            beggar_list[beg] += int(num)
            numbers.remove(num)
            break

print(beggar_list)