special_items = {"shards": 0, "fragments": 0, "motes": 0}

final_items = {"shards": 0, "fragments": 0, "motes": 0}

input_line = input().lower().split()

is_found = False

while True:

    for item in range(0, len(input_line), 2):
        quantity = int(input_line[item])
        product = input_line[item + 1]

        if product in special_items.keys():
            if final_items[product] + quantity < 250:
                final_items[product] += quantity
            else:
                if product == "Fragments".lower():
                    print("Valanyr obtained!")
                    final_items[product] += quantity
                    final_items[product] -= 250
                    is_found = True
                    break
                elif product == "Motes".lower():
                    print("Dragonwrath obtained!")
                    final_items[product] += quantity
                    final_items[product] -= 250
                    is_found = True
                    break
                elif product == "Shards".lower():
                    print("Shadowmourne obtained!")
                    final_items[product] += quantity
                    final_items[product] -= 250
                    is_found = True
                    break
        elif product in final_items.keys():
            final_items[product] += quantity
        else:
            final_items[product] = quantity

    if is_found:
        break
    else:
        input_line = input().lower().split()

print(f"shards: {final_items['shards']}\n"
f"fragments: {final_items['fragments']}\n"
f"motes: {final_items['motes']}")
for item, quantity in final_items.items():
    if item not in special_items.keys():
        print(f"{item}: {quantity}")