from collections import deque

chocolates = [int(x) for x in input().split(", ")]
cups_of_milk = deque(int(x) for x in input().split(", "))

total_milkshakes = 0

while chocolates and cups_of_milk and total_milkshakes < 5:
    chocolate = chocolates[-1]
    milk = cups_of_milk[0]

    if chocolate <= 0 or milk <= 0:
        if chocolate <= 0:
            chocolates.pop()
        if milk <= 0:
            cups_of_milk.popleft()
        continue

    if chocolate == milk:
        total_milkshakes += 1
        chocolates.pop()
        cups_of_milk.popleft()
    else:
        cups_of_milk.rotate(-1)
        chocolates[-1] -= 5

if total_milkshakes == 5:
    print(f"Great! You made all the chocolate milkshakes needed!")
else:
    print(f"Not enough milkshakes.")

print(f"Chocolate: {', '.join(map(str, chocolates)) if chocolates else 'empty'}")
print(f"Milk: {', '.join(map(str, cups_of_milk)) if cups_of_milk else 'empty'}")