
PROTECTIVE_PLASTIC = 1.50
PAINT = 14.50
PAINT_THINNER = 5.00

needed_protective_plastic = int(input())
needed_paint = int(input())
needed_paint_thinner = int(input())
hours_to_work = int(input())

needed_protective_plastic += 2
needed_paint += needed_paint * 10 / 100

sum = needed_protective_plastic * PROTECTIVE_PLASTIC + needed_paint * PAINT + 0.40 + needed_paint_thinner * PAINT_THINNER
work_per_hour = sum * 30 / 100

total_amount = sum + work_per_hour * hours_to_work

print(total_amount)