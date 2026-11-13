def grocery_store(**kwargs):
    receipt = {}

    for product, quantity in kwargs.items():
        receipt[product] = quantity

    sorted_receipt = dict(sorted(receipt.items(), key=lambda x: (-x[1], -len(x[0]), x[0])))

    final_list = []
    for key, value in sorted_receipt.items():
        final_list.append(f"{key}: {value}")

    return '\n'.join(final_list)

print(grocery_store(
    bread=2,
    pasta=2,
    eggs=20,
    carrot=1,
))