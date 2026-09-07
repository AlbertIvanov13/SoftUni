square_meters = float(input())

square_meter_price = 7.61

total_price = square_meter_price * square_meters

total_price_with_discount = total_price * 0.18

print(f"The final price is: {total_price - total_price_with_discount} lv.")
print(f"The discount is {total_price_with_discount} lv.")