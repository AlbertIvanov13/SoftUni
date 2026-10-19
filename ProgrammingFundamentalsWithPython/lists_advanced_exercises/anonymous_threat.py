elements = input().split()

command = input().split()

while command[0] != "3:1":

    if command[0] == "merge":
        start_index = int(command[1])
        end_index = int(command[2])

        if start_index < 0:
            start_index = 0

        if end_index > len(elements) - 1:
            end_index = len(elements) - 1

        for _ in range(end_index,start_index, - 1):
            elements[start_index] += elements.pop(start_index + 1)
    elif command[0] == "divide":
        index = int(command[1])
        partitions = int(command[2])

        element_parts = len(elements[index]) // partitions

        element = list(elements.pop(index))
        current_index = index
        if element_parts % len(element) == 0:
            for _ in range(partitions):
                elements.insert(index, str("".join(element[:element_parts])))
                del element[:element_parts]
                index += 1
        else:
            for _ in range(partitions):
                elements.insert(current_index, str("".join(element[:element_parts])))
                del element[:element_parts]
                current_index += 1
            else:
                if element:
                    current_index -= 1
                    elements[current_index] += str("".join(element))

    command = input().split()

print(" ".join(elements))