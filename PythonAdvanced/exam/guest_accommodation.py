def accommodate(*args, **kwargs):
    unaccommodated = 0
    empty_rooms = 0
    available_rooms = {}
    successful_accommodations = {}
    for room, capacity in kwargs.items():
        room = room.split("_")
        room_number = int(room[1])
        if room_number not in available_rooms:
            available_rooms[room_number] = capacity

    available_rooms = dict(sorted(available_rooms.items(), key=lambda x: (x[1], x[0])))

    for guests in args:
        for room, capacity in available_rooms.items():
            if guests == capacity or capacity > guests and available_rooms[room] > 0:
                successful_accommodations[room] = guests
                available_rooms[room] = 0
                break
        else:
            unaccommodated += guests

    for capacity in available_rooms.values():
        if capacity > 0:
            empty_rooms += 1

    result = ""

    if successful_accommodations:
        successful_accommodations = dict(sorted(successful_accommodations.items(), key=lambda x: (x[0])))
        result += f"A total of {len(successful_accommodations)} accommodations were completed!\n"
        for room, guests in successful_accommodations.items():
            result += f"<Room {room} accommodates {guests} guests>\n"
    else:
        result += "No accommodations were completed!\n"

    if unaccommodated > 0:
        result += f"Guests with no accommodation: {unaccommodated}\n"

    if empty_rooms > 0:
        result += f"Empty rooms: {empty_rooms}\n"

    return result

print(accommodate(1, 2, 4, 8, room_102=3, room_101=1, room_103=2))