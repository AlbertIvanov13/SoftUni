input_line = input()

rage_message = ""

message_to_add = ""

multiplier = ""

unique_symbols = []

for symbol in range(len(input_line)):
    if not input_line[symbol].isdigit():
        message_to_add += input_line[symbol].upper()
        unique_symbols.append(input_line[symbol].upper())
    else:
        multiplier += input_line[symbol]
        if symbol + 1 >= len(input_line):
            rage_message += message_to_add * int(multiplier)
        elif input_line[symbol + 1].isdigit():
            multiplier += input_line[symbol + 1]
            rage_message += message_to_add * int(int(multiplier))
        else:
            rage_message += message_to_add * int(multiplier)

        message_to_add = ""
        multiplier = ""

print(f"Unique symbols used: {len(set(unique_symbols))}")
print(rage_message)