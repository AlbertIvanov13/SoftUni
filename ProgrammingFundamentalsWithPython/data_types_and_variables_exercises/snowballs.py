from random import weibullvariate

number_of_snowballs = int(input())

biggest_value = 0

weight = 0
time = 0
quality = 0
value = 0

for _ in range(number_of_snowballs):
    weight_of_snowball = int(input())
    needed_time = int(input())
    quality_of_snowball = int(input())

    current_value = (weight_of_snowball // needed_time) ** quality_of_snowball

    if current_value > biggest_value:
        biggest_value = current_value
        quality = quality_of_snowball
        time = needed_time
        weight = weight_of_snowball


print(f"{weight} : {time} = {biggest_value} ({quality})")