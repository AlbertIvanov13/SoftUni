from collections import deque

quantity_of_food = int(input())

integers = input().split()

orders = deque()

for integer in integers:
    orders.append(int(integer))

print(max(orders))

while orders:
    if orders[0] <= quantity_of_food:
        quantity_of_food -= orders[0]
        orders.popleft()
    else:
        print(f"Orders left: {' '.join(str(order) for order in orders)}")
        break

if not orders:
    print("Orders complete")