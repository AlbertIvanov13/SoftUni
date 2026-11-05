odd_set = set()
even_set = set()

for i in range(1, int(input()) + 1):
    current_num = sum(ord(ch) for ch in input()) // i

    if current_num % 2 == 0:
        even_set.add(current_num)
    else:
        odd_set.add(current_num)

odd_set_sum = sum(odd_set)
even_set_sum = sum(even_set)

if odd_set_sum == even_set_sum:
    print(*odd_set.union(even_set), sep=', ')
elif odd_set_sum > even_set_sum:
    print(*odd_set.difference(even_set), sep=', ')
else:
    print(*odd_set.symmetric_difference(even_set), sep=', ')