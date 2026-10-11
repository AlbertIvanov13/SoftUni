budget = float(input())
price_for_kilogram_flour = float(input())

number_of_loaves = 0
colored_eggs = 0

price_for_egg_pack = price_for_kilogram_flour * 0.75
price_for_liter_milk = price_for_kilogram_flour * 1.25

price_for_milk_per_loaf = price_for_liter_milk * 0.25

current_price = price_for_kilogram_flour + price_for_egg_pack + price_for_milk_per_loaf

while budget > current_price:
    current_price = price_for_kilogram_flour + price_for_egg_pack + price_for_milk_per_loaf
    budget -= current_price

    number_of_loaves += 1
    colored_eggs += 3

    if number_of_loaves % 3 == 0:
        colored_eggs -= number_of_loaves - 2

print(f"You made {number_of_loaves} loaves of Easter bread! Now you have {colored_eggs} eggs and {budget:.2f}BGN left.")