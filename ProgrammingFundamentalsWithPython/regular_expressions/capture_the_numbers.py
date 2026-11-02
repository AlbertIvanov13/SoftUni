import re

current_string = input()

digits = []

while current_string:

    expression = r"\d+"

    digits += re.findall(expression, current_string)

    current_string = input()


print(" ".join(digits))