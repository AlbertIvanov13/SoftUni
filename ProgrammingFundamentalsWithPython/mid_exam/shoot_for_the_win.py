targets = input().split()

command = input()

count_of_shots = 0

while command != 'End':

    index = int(command)

    if index > len(targets) - 1 or index < 0:
        command = input()
        continue
    else:
        element = targets.index(targets[index])
        value = int(targets[element])
        targets[index] = "-1"
        if value == -1:
            command = input()
            continue
        for target in range(len(targets)):
            if targets[target] == "-1":
                continue
            else:
                if int(targets[target]) > value:
                    reduce_element = int(targets[target])
                    reduce_element -= value
                    targets[target] = str(reduce_element)
                else:
                    increase_element = int(targets[target])
                    increase_element += value
                    targets[target] = str(increase_element)
        count_of_shots += 1

    command = input()

print(f"Shot targets: {count_of_shots} ->", end=" ")
print(*targets)