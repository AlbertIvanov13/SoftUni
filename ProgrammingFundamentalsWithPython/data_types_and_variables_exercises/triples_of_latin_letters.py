number = int(input())

result = ""

for first_letter in range(97, 97 + number):
    for second_letter in range(97, 97 + number):
        for third_letter in range(97, 97 + number):
            result = chr(first_letter) + chr(second_letter) + chr(third_letter)
            print(result)