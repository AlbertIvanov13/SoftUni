def fill_the_box(height, length, width, *args):
    box_size = height * length * width

    total_count = 0

    for arg in args:
        if str(arg).isdigit():
            total_count += arg
        if total_count > box_size:
            total_count -= box_size
            remaining_sum = total_count + sum(args[args.index(arg) + 1:args.index("Finish")])
            return f"No more free space! You have {remaining_sum} more cubes."
        if arg == "Finish":
            if total_count < box_size:
                return f"There is free space in the box. You could put {box_size - total_count} more cubes."
    return ""

print(fill_the_box(10, 10, 10, 40, "Finish", 2, 15, 30))