from collections import deque

packages = list(map(int, input().split()))
couriers = deque(map(int, input().split()))

total_packages_weight = 0

while packages and couriers:
    last_package = packages[-1]
    first_courier = couriers.popleft()

    if first_courier >= last_package:
        first_courier -= last_package * 2
        total_packages_weight += packages.pop()

        if first_courier > 0:
            couriers.append(first_courier)
    else:
        result = packages[-1] - (packages[-1] - first_courier)
        packages[-1] -= result
        total_packages_weight += result

print(f"Total weight: {total_packages_weight} kg")
if not packages and not couriers:
    print("Congratulations, all packages were delivered successfully by the couriers today.")
elif packages and not couriers:
    print(f"Unfortunately, there are no more available couriers to deliver the following packages: {', '.join(map(str, packages))}")
elif couriers and not packages:
    print(f"Couriers are still on duty: {', '.join(map(str, couriers))} but there are no more packages to deliver.")