year_tax = int(input())

basketball_snickers = year_tax - year_tax *  0.4
basketball_kit = basketball_snickers  - basketball_snickers * 0.2
basketball_ball = basketball_kit * 1 / 4
basketball_accessories = basketball_ball * 1 / 5

total_price = basketball_snickers + basketball_kit + basketball_ball + basketball_accessories + year_tax

print(f"{total_price:.2f}")