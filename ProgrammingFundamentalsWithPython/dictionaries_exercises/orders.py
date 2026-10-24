products_and_prices = {}

command = input()

while command != "buy":

    new_command = command.split()
    name = new_command[0]
    price = float(new_command[1])
    quantity = int(new_command[2])

    if name not in products_and_prices.keys():
        products_and_prices[name] = [price, quantity]
    else:
        if price != products_and_prices[name][0]:
            products_and_prices[name][1] += quantity
            products_and_prices[name][0] = price

    command = input()

for name, price in products_and_prices.items():
    print(f"{name} -> {price[0] * price[1]:.2f}")