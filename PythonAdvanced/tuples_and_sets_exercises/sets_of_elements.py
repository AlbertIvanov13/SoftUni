n, m = input().split()
n = int(n)
m = int(m)

first_set = set()
second_set = set()

length = n + m

for i in range(length):

    element = input()
    if i < n:
        first_set.add(element)
    else:
        second_set.add(element)

final_set = first_set.intersection(second_set)
print(*final_set, sep='\n')