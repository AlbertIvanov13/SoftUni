from collections import deque

robot_information = input().split(";")
robots = []

for robot in robot_information:
    robot_name, robot_time = robot.split("-")
    robots.append({"name": robot_name, "time": int(robot_time), "busy_until": 0})

h, m, s = [int(x) for x in input().split(":")]
start_time_in_seconds = h * 3600 + m * 60 + s

products = deque()
while True:
    product = input()
    if product == "End":
        break
    products.append(product)

while products:
    current_product = products.popleft()
    start_time_in_seconds += 1

    for robot in robots:
        if robot["busy_until"] <= start_time_in_seconds:
            robot["busy_until"] = start_time_in_seconds + robot["time"]
            hours = start_time_in_seconds // 3600
            minutes = (start_time_in_seconds % 3600) // 60
            seconds = (start_time_in_seconds % 3600) % 60
            hours %= 24
            print(f"{robot['name']} - {current_product} [{hours:02d}:{minutes:02d}:{seconds:02d}]")
            break
    else:
        products.append(current_product)