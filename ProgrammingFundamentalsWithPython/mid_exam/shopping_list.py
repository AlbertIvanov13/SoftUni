list_of_groceries = input().split("!")

command = input().split()

while command[0] != "Go":

    if command[0] == "Urgent":
        item = command[1]

        if item not in list_of_groceries:
            list_of_groceries.insert(0, item)
    elif command[0] == "Unnecessary":
        item = command[1]
        if item in list_of_groceries:
            list_of_groceries.remove(item)
    elif command[0] == "Correct":
        old_item = command[1]
        new_item = command[2]

        if old_item in list_of_groceries:
            old_item_index = list_of_groceries.index(old_item)
            list_of_groceries.remove(old_item)
            list_of_groceries.insert(old_item_index, new_item)
    elif command[0] == "Rearrange":
        item = command[1]
        if item in list_of_groceries:
            item_index = list_of_groceries.index(item)
            grocery = list_of_groceries.pop(item_index)
            list_of_groceries.append(grocery)


    command = input().split()

print(", ".join(list_of_groceries))