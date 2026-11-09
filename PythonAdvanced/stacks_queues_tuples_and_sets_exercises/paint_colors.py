from collections import deque

color_string = deque(input().split())

main_colors = ("red", "yellow", "blue")
secondary_colors = {
    "orange": ("red", "yellow"),
    "purple": ("blue", "red"),
    "green": ("yellow", "blue"),
}
collected_colors = []

while color_string:
    first_string = color_string.popleft()
    last_string = color_string.pop() if color_string else ""
    for color in (first_string + last_string, last_string + first_string):
        if color in main_colors or color in secondary_colors:
            collected_colors.append(color)
            break
    else:
        if len(first_string) > 1:
            color_string.insert(len(color_string) // 2, first_string[:-1])
        if len(last_string) > 1:
            color_string.insert(len(color_string) // 2, last_string[:-1])

valid_colors = []
for c in collected_colors:
    if c in main_colors:
        valid_colors.append(c)
    elif c in secondary_colors:
        for main_c in secondary_colors[c]:
            if main_c not in collected_colors:
                break
        else:
            valid_colors.append(c)

print(valid_colors)