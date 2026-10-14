deck_of_cards = input().split()
shuffles_count = int(input())

shuffled_deck = []

for _ in range(shuffles_count):

    if any(shuffled_deck):
        first_half = shuffled_deck[:len(shuffled_deck) // 2]
        second_half = shuffled_deck[len(shuffled_deck) // 2:]
        shuffled_deck = []
    else:
        first_half = deck_of_cards[:len(deck_of_cards) // 2]
        second_half = deck_of_cards[len(deck_of_cards) // 2:]

    while any(first_half):
        for card in first_half:
            shuffled_deck.append(card)
            first_half.remove(card)
            break

        for card in second_half:
            shuffled_deck.append(card)
            second_half.remove(card)
            break

print(shuffled_deck)