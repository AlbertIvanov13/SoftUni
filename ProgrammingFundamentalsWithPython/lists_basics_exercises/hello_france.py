from xml.etree.ElementInclude import default_loader

items = input().split("|")
budget = float(input())

old_budget = budget
bought_items = []

profit = 0

for item in items:
    new_item = item.split("->")

    if new_item[0] == "Clothes":
        if float(new_item[1]) > 50:
            continue
        else:
            if float(new_item[1]) <= budget:
                budget -= float(new_item[1])
                bought_items.append(float(new_item[1]) * 1.40)
    elif new_item[0] == "Shoes":
        if float(new_item[1]) > 35:
            continue
        else:
            if float(new_item[1]) <= budget:
                budget -= float(new_item[1])
                bought_items.append(float(new_item[1]) * 1.40)
    elif new_item[0] == "Accessories":
        if float(new_item[1]) > 20.50:
            continue
        else:
            if float(new_item[1]) <= budget:
                budget -= float(new_item[1])
                bought_items.append(float(new_item[1]) * 1.40)

for item in bought_items:
    budget += item

profit = budget - old_budget

for item in bought_items:
    print(f"{item:.2f}", end = " ")
print()

print(f"Profit: {profit:.2f}")

if budget >= 150:
    print("Hello, France!")
else:
    print("Not enough money.")