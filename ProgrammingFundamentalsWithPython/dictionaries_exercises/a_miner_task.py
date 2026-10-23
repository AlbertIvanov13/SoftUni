resources = {}

command = input()

while command != "stop":

    quality = int(input())

    if command not in resources.keys():
        resources[command] = quality
    else:
        resources[command] += quality

    command = input()

for resource, quality in resources.items():
    print(f"{resource} -> {quality}")