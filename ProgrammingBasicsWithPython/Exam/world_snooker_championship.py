stage = input()
ticket_type = input()
ticket_count = int(input())
photo_with_trophy = input()

total_amount = 0
is_Free = True

if stage == "Quarter final":
    if ticket_type == "Standard":
        total_amount = ticket_count * 55.50

    elif ticket_type == "Premium":
        total_amount = ticket_count * 105.20

    elif ticket_type == "VIP":
        total_amount = ticket_count * 118.90

elif stage == "Semi final":
    if ticket_type == "Standard":
        total_amount = ticket_count * 75.88

    elif ticket_type == "Premium":
        total_amount = ticket_count * 125.22

    elif ticket_type == "VIP":
        total_amount = ticket_count * 300.40

elif stage == "Final":
    if ticket_type == "Standard":
        total_amount = ticket_count * 110.10

    elif ticket_type == "Premium":
        total_amount = ticket_count * 160.66

    elif ticket_type == "VIP":
        total_amount = ticket_count * 400




if total_amount > 4000:
    total_amount -= total_amount * 0.25
    is_Free = False

elif total_amount > 2500:
    total_amount -= total_amount * 0.10

if photo_with_trophy == "Y" and is_Free == True:
    total_amount += 40 * ticket_count

print(f"{total_amount:.2f}")