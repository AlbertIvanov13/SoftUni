def characters_in_range(first_char: str, second_char: str) -> list:
    characters = []
    for character in range(ord(first_char) + 1, ord(second_char)):
        characters.append(chr(character))

    return characters

first_character = input()
second_character = input()

characters_in_range = characters_in_range(first_character, second_character)
print(" ".join(characters_in_range))