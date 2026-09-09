import math

CHICKEN_MENU = 10.35
FISH_MENU = 12.40
VEGETARIAN_MENU = 8.15

chicken_menu_count = int(input())
fish_menu_count = int(input())
vegetarian_menu_count = int(input())

total_bill = chicken_menu_count * CHICKEN_MENU + fish_menu_count * FISH_MENU + vegetarian_menu_count * VEGETARIAN_MENU
dessert = total_bill * 20 / 100

total_sum = total_bill + dessert + 2.50

print(f"{total_sum:.2f}")