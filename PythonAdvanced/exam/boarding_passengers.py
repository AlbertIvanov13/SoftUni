def boarding_passengers(capacity, *args):
    benefit_programs = {}
    remaining = 0
    for arg in args:
        if capacity - int(arg[0]) >= 0:
            capacity -= int(arg[0])
        else:
            remaining += int(arg[0])
            continue
        if arg[1] not in benefit_programs:
            benefit_programs[arg[1]] = 0
        benefit_programs[arg[1]] += int(arg[0])

    benefit_programs = dict(sorted(benefit_programs.items(), key=lambda x: (-x[1], x[0])))
    result = ""
    result += "Boarding details by benefit plan:\n"
    for key, value in benefit_programs.items():
        result += f"## {key}: {value} guests\n"
    if remaining == 0 and capacity == 0:
        result += "All passengers are successfully boarded!"
    elif remaining > 0 and capacity == 0:
        result += "Boarding unsuccessful. Cruise ship at full capacity."
    else:
        result += f"Partial boarding completed. Available capacity: {capacity}."
    return result.strip()

print(boarding_passengers(120, (30, 'Gold'), (20, 'Platinum'), (30, 'Diamond'), (10, 'First Cruiser'), (31, 'Platinum'), (20, 'Diamond')))