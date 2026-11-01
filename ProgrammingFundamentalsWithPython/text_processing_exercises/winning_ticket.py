def check_ticket(ticket: str) -> str:

    if len(ticket) == 20:
        first_half = ticket[:10]
        second_half = ticket[10:]
        symbols = ("@", "#", "$", "^")
        for count in range(10, 5, -1):
            for symbol in symbols:
                if symbol * count in first_half and symbol * count in second_half:
                    if count == 10:
                        return f'ticket "{ticket}" - {count}{symbol} Jackpot!'
                    return f'ticket "{ticket}" - {count}{symbol}'
        return f'ticket "{ticket}" - no match'
    return "invalid ticket"

tickets = [ticket.strip() for ticket in input().split(", ")]

for ticket in tickets:
    print(check_ticket(ticket))