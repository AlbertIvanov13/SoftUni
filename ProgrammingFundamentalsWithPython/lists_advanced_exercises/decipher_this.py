secret_message = input().split()

new_word = []

final_sentence = []

for word in secret_message:
    number = ""
    letter = ""
    for symbol in range(len(word)):
        if word[symbol].isdigit():
            number += str(word[symbol])
            continue
        else:
            new_word.append(word[symbol])
    else:
        missing_letter = chr(int(number))
        new_word.insert(0, missing_letter)
        new_word[1], new_word[-1] = new_word[-1], new_word[1]

    sentence = ""
    for letter in new_word:
        sentence += letter
    else:
        final_sentence.append(sentence)

    new_word = []

print(" ".join(final_sentence))