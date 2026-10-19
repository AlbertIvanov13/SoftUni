number_of_electrons = int(input())

remaining_electrons = number_of_electrons

final_list = []

position_of_a_shell = 0

while sum(final_list) < number_of_electrons:
    position_of_a_shell += 1
    result = position_of_a_shell ** 2 * 2
    if result > remaining_electrons:
        final_list.append(remaining_electrons)
        remaining_electrons -= result
    else:
        final_list.append(position_of_a_shell ** 2 * 2)
        remaining_electrons -= result

print(final_list)