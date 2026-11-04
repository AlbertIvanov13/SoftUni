expression = input()

parentheses = {"(": ")", "[": "]", "{": "}"}
current_capacity = 0

stack = []

for character in expression:
    if character in parentheses:
        stack.append(character)
    elif character in parentheses.values():
        if not stack:
            print("NO")
            break
        last_opening = stack.pop()
        if parentheses[last_opening] != character:
            print("NO")
            break
else:
    if stack:
        print("No")
    else:
        print("YES")