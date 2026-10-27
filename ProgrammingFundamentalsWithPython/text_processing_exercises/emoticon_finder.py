input_string = input()

emoticons = []

for char in range(len(input_string)):
    if input_string[char] == ":":
        emoticons.append(":" + str(input_string[char + 1]))

for emoticon in emoticons:
    print(emoticon)