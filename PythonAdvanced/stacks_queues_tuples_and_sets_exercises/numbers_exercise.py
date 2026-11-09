first_sequence = set(int(x) for x in input().split())
second_sequence = set(int(y) for y in input().split())

n = int(input())

for _ in range(n):
    command = input().split()

    if command[0] + command[1] == "CheckSubset":
        if first_sequence.issubset(second_sequence) or second_sequence.issubset(first_sequence):
            print("True")
        else:
            print("False")
        continue
    numbers = command[2:]
    for number in numbers:
        if command[0] + command[1] == "AddFirst":
            first_sequence.add(int(number))
        elif command[0] + command[1] == "AddSecond":
            second_sequence.add(int(number))
        elif command[0] + command[1] == "RemoveFirst":
            if int(number) in first_sequence:
                first_sequence.remove(int(number))
        elif command[0] + command[1] == "RemoveSecond":
            if int(number) in second_sequence:
                second_sequence.remove(int(number))

first_sequence = sorted(first_sequence)
second_sequence = sorted(second_sequence)
print(*first_sequence, sep=", ")
print(*second_sequence, sep=", ")