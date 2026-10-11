number_of_messages = int(input())

for _ in range(number_of_messages):
    message_code = int(input())
    if message_code == 88:
        print("Hello")
    elif message_code == 86:
        print("How are you?")
    elif not 88 or 86 and message_code < 88:
        print("GREAT!")
    elif message_code > 88:
        print("Bye.")
