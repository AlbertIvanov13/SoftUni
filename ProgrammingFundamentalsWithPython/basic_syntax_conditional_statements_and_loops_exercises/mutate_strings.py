first_string = input()
second_string = input()

new_string = ""

first_index = 0
second_index = 0

for _ in range(len(first_string)):
    if first_string[first_index] != second_string[second_index]:
        new_string = second_string[:second_index + 1] + first_string[first_index + 1:]
        print(new_string)
        first_index += 1
        second_index += 1
    else:
        first_index += 1
        second_index += 1
        continue