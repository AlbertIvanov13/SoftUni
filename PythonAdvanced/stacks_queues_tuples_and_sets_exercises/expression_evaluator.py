from collections import deque

expression = input().split()

numbers = deque()

result = 0

for char in expression:
    if char == "*":
        result = numbers.popleft()
        for num in range(len(numbers)):
            result *= numbers.popleft()
        else:
            numbers.append(result)
    elif char == "+":
        result = numbers.popleft()
        for num in range(len(numbers)):
            result += numbers.popleft()
        else:
            numbers.append(result)
    elif char == "-":
        result = numbers.popleft()
        for num in range(len(numbers)):
            result -= numbers.popleft()
        else:
            numbers.append(result)
    elif char == "/":
        result = numbers.popleft()
        for num in range(len(numbers)):
            result //= numbers.popleft()
        else:
            numbers.append(result)
    else:
        numbers.append(int(char))

print(result)