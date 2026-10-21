sequence_of_elements = input().split()

command = input()

number_of_moves = 0

have_won = False

while command != "end":

    indexes = command.split()

    first_index = int(indexes[0])
    second_index = int(indexes[1])

    number_of_moves += 1

    if first_index == second_index:
        sequence_of_elements.insert(len(sequence_of_elements) // 2, f"-{number_of_moves}a")
        sequence_of_elements.insert(len(sequence_of_elements) // 2, f"-{number_of_moves}a")

        print("Invalid input! Adding additional elements to the board")
    elif (first_index < 0 or first_index > len(sequence_of_elements) - 1) or (second_index < 0 or second_index > len(sequence_of_elements) - 1):
        sequence_of_elements.insert(len(sequence_of_elements) // 2,  f"-{number_of_moves}a")
        sequence_of_elements.insert(len(sequence_of_elements) // 2,  f"-{number_of_moves}a")

        print("Invalid input! Adding additional elements to the board")

    elif sequence_of_elements[first_index] == sequence_of_elements[second_index]:
        first_element = sequence_of_elements[first_index]
        second_element = sequence_of_elements[second_index]
        sequence_of_elements.remove(first_element)
        sequence_of_elements.remove(second_element)
        print(f"Congrats! You have found matching elements - {first_element}!")

    elif sequence_of_elements[first_index] != sequence_of_elements[second_index]:
        print("Try again!")

    elements = list(set(sequence_of_elements))

    if len(elements) == len(sequence_of_elements):
        print(f"You have won in {number_of_moves} turns!")
        have_won = True
        break

    command = input()

if not have_won:
    print("Sorry you lose :(")
    print(" ".join(sequence_of_elements))