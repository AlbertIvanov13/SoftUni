age = int(input())
drink = ""
if age <= 14:
    drink = "toddy"
    print(f"drink {drink}")
elif age <= 18:
    drink = "coke"
    print(f"drink {drink}")
elif age <= 21:
    drink = "beer"
    print(f"drink {drink}")
elif age > 21:
    drink = "whisky"
    print(f"drink {drink}")