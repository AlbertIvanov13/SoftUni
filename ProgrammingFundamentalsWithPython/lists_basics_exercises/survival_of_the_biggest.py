import sys

numbers = input().split()
counter = int(input())

new_list = []

int_list = list(map(int, numbers))

for _ in range(counter):
    int_list.remove(min(int_list))

new_list = list(map(str, int_list))

print(", ".join(new_list))