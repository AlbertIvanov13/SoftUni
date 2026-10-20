first_sequence = input().split(", ")
second_sequence = input().split(", ")

final_list = []

for substring in first_sequence:
    for word in second_sequence:
        if substring in word:
            final_list.append(substring)
            break

print(final_list)