number_of_rooms = int(input())

free_chairs = 0

all_rooms_active = True

for room in range(1, number_of_rooms + 1):
    room_information = input().split()

    chairs = len(room_information[0])
    visitors = int(room_information[1])

    if visitors > chairs:
        needed_chairs = visitors - chairs
        print(f"{needed_chairs} more chairs needed in room {room}")
        all_rooms_active = False
    elif chairs > visitors:
        free_chairs += chairs - visitors

if all_rooms_active:
    print(f"Game On, {free_chairs} free chairs left")