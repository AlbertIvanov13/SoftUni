country = input()
appliance = input()

total_score = 0
score = 0

if country == "Russia":
    if appliance == "ribbon":
        level = 9.100
        performance = 9.400
        score = level + performance
        print(f"The team of {country} get {score:.3f} on {appliance}.")
        print(f"{100 - (100 / 20 * score):.2f}%")
    elif appliance == "hoop":
        level = 9.300
        performance = 9.800
        score = level + performance
        print(f"The team of {country} get {score:.3f} on {appliance}.")
        print(f"{100 - (100 / 20 * score):.2f}%")
    elif appliance == "rope":
        level = 9.600
        performance = 9.000
        score = level + performance
        print(f"The team of {country} get {score:.3f} on {appliance}.")
        print(f"{100 - (100 / 20 * score):.2f}%")
elif country == "Bulgaria":
    if appliance == "ribbon":
        level = 9.600
        performance = 9.400
        score = level + performance
        print(f"The team of {country} get {score:.3f} on {appliance}.")
        print(f"{100 - (100 / 20 * score):.2f}%")
    elif appliance == "hoop":
        level = 9.550
        performance = 9.750
        score = level + performance
        print(f"The team of {country} get {score:.3f} on {appliance}.")
        print(f"{100 - (100 / 20 * score):.2f}%")
    elif appliance == "rope":
        level = 9.500
        performance = 9.400
        score = level + performance
        print(f"The team of {country} get {score:.3f} on {appliance}.")
        print(f"{100 - (100 / 20 * score):.2f}%")
elif country == "Italy":
    if appliance == "ribbon":
        level = 9.200
        performance = 9.500
        score = level + performance
        print(f"The team of {country} get {score:.3f} on {appliance}.")
        print(f"{100 - (100 / 20 * score):.2f}%")
    elif appliance == "hoop":
        level = 9.450
        performance = 9.350
        score = level + performance
        print(f"The team of {country} get {score:.3f} on {appliance}.")
        print(f"{100 - (100 / 20 * score):.2f}%")
    elif appliance == "rope":
        level = 9.700
        performance = 9.150
        score = level + performance
        print(f"The team of {country} get {score:.3f} on {appliance}.")
        print(f"{100 - (100 / 20 * score):.2f}%")