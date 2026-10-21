items = input().split(", ")

command = input()

while command != "Craft!":

    commands = command.split(" - ")

    if commands[0] == "Collect":
        item = commands[1]

        if item not in items:
            items.append(item)
    elif commands[0] == "Drop":
        item = commands[1]

        if item in items:
            items.remove(item)
    elif commands[0] == "Combine Items":
        combined_items = commands[1].split(":")
        old_item = combined_items[0]
        new_item = combined_items[1]

        if old_item in items:
            old_item_index = items.index(old_item)
            items.insert(old_item_index + 1, new_item)
    elif commands[0] == "Renew":
        item = commands[1]

        if item in items:
            item_to_change = items.pop(items.index(item))
            items.append(item_to_change)

    command = input()

print(", ".join(items))