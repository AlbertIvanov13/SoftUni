number_sequence = list(map(int, input().split()))

sum_of_removed_elements = 0

while number_sequence:
    index = int(input())

    if index < 0:
        removed_element = number_sequence.pop(0)
        number_sequence.insert(0, number_sequence[-1])

        sum_of_removed_elements += int(removed_element)

        for number in range(len(number_sequence)):
            if number_sequence[number] <= int(removed_element):
                number_sequence[number] += int(removed_element)
            elif number_sequence[number] > int(removed_element):
                number_sequence[number] -= int(removed_element)
    elif index > len(number_sequence) - 1:
        removed_element = number_sequence.pop(-1)
        number_sequence.append(number_sequence[0])

        sum_of_removed_elements += int(removed_element)

        for number in range(len(number_sequence)):
            if number_sequence[number] <= int(removed_element):
                number_sequence[number] += int(removed_element)
            elif number_sequence[number] > int(removed_element):
                number_sequence[number] -= int(removed_element)
    else:
        removed_element = number_sequence.pop(index)

        sum_of_removed_elements += int(removed_element)

        for number in range(len(number_sequence)):
            if number_sequence[number] <= int(removed_element):
                number_sequence[number] += int(removed_element)
            elif number_sequence[number] > int(removed_element):
                number_sequence[number] -= int(removed_element)

print(sum_of_removed_elements)