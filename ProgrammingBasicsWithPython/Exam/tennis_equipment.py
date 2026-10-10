import math

rocket_price = float(input())
rocket_count = int(input())
snickers_count = int(input())
snickers_price = rocket_price / 6

total_price = rocket_count * rocket_price + snickers_count * snickers_price

other_equipment_price = total_price * 0.20

print(f"Price to be paid by Djokovic {math.floor((total_price + other_equipment_price) * 1 / 8)}")
print(f"Price to be paid by sponsors {math.ceil((total_price + other_equipment_price) * 7 / 8)}")