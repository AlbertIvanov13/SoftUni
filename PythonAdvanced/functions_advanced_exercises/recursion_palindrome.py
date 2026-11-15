def palindrome(word, index):

    if index < 0:
        return

    if word == word[::-1]:
        palindrome(word, index - 1)
        return f"{word} is a palindrome"
    else:
        return f"{word} is not a palindrome"

print(palindrome("abcba", 0))