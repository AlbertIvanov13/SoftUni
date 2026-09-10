
PENCIL_PACK_PRICE = 5.80
MARKER_PACK_PRICE = 7.20
PREPARAT_PER_LITER_PRICE = 1.20

pencil_packs = int(input())
markers_packs = int(input())
preparat_liters = int(input())
discount_rate = int(input())

sum = pencil_packs * PENCIL_PACK_PRICE + markers_packs * MARKER_PACK_PRICE + preparat_liters * PREPARAT_PER_LITER_PRICE

discount = sum * (discount_rate / 100)

total_amount = sum - discount

print(total_amount)