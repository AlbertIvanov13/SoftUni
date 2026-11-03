import re

string = input()
word = input()
pattern = fr"\b{word}\b"
found_words = re.findall(pattern, string, re.IGNORECASE)

print(len(found_words))