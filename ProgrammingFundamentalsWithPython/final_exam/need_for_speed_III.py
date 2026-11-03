number_of_cars = int(input())

cars = {}

for _ in range(number_of_cars):

    current_car = input().split("|")
    car_model = current_car[0]
    mileage = int(current_car[1])
    fuel = int(current_car[2])
    cars[car_model] = {"mileage": mileage, "fuel": fuel}

command = input()

while command != "Stop":

    command = command.split(" : ")

    if command[0] == "Drive":
        car = command[1]
        distance = int(command[2])
        current_fuel = int(command[3])
        if cars[car]["fuel"] >= current_fuel:
            cars[car]["mileage"] += distance
            cars[car]["fuel"] -= current_fuel
            print(f"{car} driven for {distance} kilometers. {current_fuel} liters of fuel consumed.")
        else:
            print("Not enough fuel to make that ride")

        if cars[car]["mileage"] >= 100000:
            del cars[car]
            print(f"Time to sell the {car}!")
    elif command[0] == "Refuel":
        car = command[1]
        current_fuel = int(command[2])
        if cars[car]["fuel"] + current_fuel > 75:
            print(f"{car} refueled with {75 - cars[car]['fuel']} liters")
            cars[car]["fuel"] += 75 - cars[car]["fuel"]
        else:
            print(f"{car} refueled with {current_fuel} liters")
            cars[car]["fuel"] += current_fuel
    elif command[0] == "Revert":
        car = command[1]
        kilometers = int(command[2])
        if cars[car]["mileage"] - kilometers < 10000:
            cars[car]["mileage"] = 10000
        else:
            cars[car]["mileage"] -= kilometers
            print(f"{car} mileage decreased by {kilometers} kilometers")

    command = input()

for car, values in cars.items():
    print(f"{car} -> Mileage: {values['mileage']} kms, Fuel in the tank: {values['fuel']} lt.")