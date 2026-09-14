room_for_one_person = 18.00
apartment = 25.00
president_apartment = 35.00

staying_days = int(input()) - 1
room_type = input()
rate = input()

total_price = 0

if room_type == "room for one person":
    total_price = staying_days * room_for_one_person
elif room_type == "apartment":
    if staying_days < 10:
        total_price = staying_days * apartment
        total_price -= total_price * 30 / 100
    elif 10 <= staying_days <= 15:
        total_price = staying_days * apartment
        total_price -= total_price * 35 / 100
    else:
        total_price = staying_days * apartment
        total_price -= total_price * 50 / 100
elif room_type == "president apartment":
    if staying_days < 10:
        total_price = staying_days * president_apartment
        total_price -= total_price * 10 / 100
    elif 10 <= staying_days <= 15:
        total_price = staying_days * president_apartment
        total_price -= total_price * 15 / 100
    else:
        total_price = staying_days * president_apartment
        total_price -= total_price * 20 / 100


if rate == "positive":
    total_price += total_price * 25 / 100
elif rate == "negative":
    total_price -= total_price * 10 / 100

print(f"{total_price:.2f}")