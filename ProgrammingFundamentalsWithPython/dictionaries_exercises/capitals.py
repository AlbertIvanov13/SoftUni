country_names = input().split(", ")
capitals = input().split(", ")

countries_and_capitals = {country: capital for country, capital in zip(country_names, capitals)}

for country, capital in countries_and_capitals.items():
    print(f"{country} -> {capital}")