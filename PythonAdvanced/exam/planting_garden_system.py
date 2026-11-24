def plant_garden(space: float, *plants, **requested_plants):
    planting_requests = {}
    planted_plants = {}
    both_containing = {}

    for plant, count in requested_plants.items():
        planting_requests[plant] = count

    planting_requests = dict(sorted(planting_requests.items(), key=lambda item: item[0]))

    for p, q in planting_requests.items():
        for pl in plants:
            if p == pl[0]:
                both_containing[p] = q

    for p, q in both_containing.items():
        for pl in plants:
            if p not in planted_plants:
                planted_plants[p] = q
            if p == pl[0]:
                for _ in range(q):
                 if pl[1] <= space:
                     space = round(float(space - pl[1]), 2)
                     both_containing[p] -= 1
                 else:
                     break

    result = ""
    if all(p == 0 for p in both_containing.values()):
        result += f"All plants were planted! Available garden space: {space:.1f} sq meters.\n"
    else:
        result += "Not enough space to plant all requested plants!\n"
    planted_plants = dict(sorted(planted_plants.items(), key=lambda item: item[0]))
    result += "Planted plants:\n"
    for p, q in both_containing.items():
        r = planted_plants[p] - both_containing[p]
        if r > 0:
            result += f"{p}: {r}\n"
    return result

print(plant_garden(0.3, ("daisy", 0.1), daisy=3))