def list_roman_emperors(*args, **kwargs):
    successful_emperors = {}
    unsuccessful_emperors = {}

    for emperor in args:
        if emperor[1]:
            successful_emperors[emperor[0]] = kwargs[emperor[0]]
        else:
            unsuccessful_emperors[emperor[0]] = kwargs[emperor[0]]

    successful_emperors = dict(sorted(successful_emperors.items(), key=lambda x: (-x[1], x[0])))
    unsuccessful_emperors = dict(sorted(unsuccessful_emperors.items(), key=lambda x: (x[1], x[0])))

    result = ""
    result += f"Total number of emperors: {len(successful_emperors) + len(unsuccessful_emperors)}\n"
    if successful_emperors:
        result += "Successful emperors:\n"
        for emperor, length in successful_emperors.items():
            result += f"****{emperor}: {length}\n"
    if unsuccessful_emperors:
        result += "Unsuccessful emperors:\n"
        for emperor, length in unsuccessful_emperors.items():
            result += f"****{emperor}: {length}\n"
    return result

print(list_roman_emperors(("Augustus", True), ("Trajan", True), ("Claudius", True), Augustus=40, Trajan=19, Claudius=13,))