box_of_clothes = input().split()

capacity_for_rack = int(input())


total_racks = 0

while box_of_clothes:
    total_racks += 1
    current_capacity = capacity_for_rack
    while box_of_clothes and current_capacity >= int(box_of_clothes[-1]):
        current_capacity -= int(box_of_clothes.pop())

print(total_racks)