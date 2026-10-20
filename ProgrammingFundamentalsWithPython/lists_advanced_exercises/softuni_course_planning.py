schedule = input().split(", ")

command = input()

while command != "course start":

    command = command.split(":")

    if command[0] == "Add":
        lesson_title = command[1]
        if lesson_title not in schedule:
            schedule.append(lesson_title)
    elif command[0] == "Insert":
        lesson_title = command[1]
        index = int(command[2])
        if lesson_title not in schedule:
            schedule.insert(index, lesson_title)
    elif command[0] == "Remove":
        lesson_title = command[1]
        if lesson_title in schedule:
            schedule.remove(lesson_title)
            if lesson_title + "-Exercise" in schedule:
                index = schedule.index(lesson_title + "-Exercise")
                element = schedule[index]
                schedule.remove(element)
    elif command[0] == "Swap":
        first_lesson_title = command[1]
        second_lesson_title = command[2]

        if first_lesson_title in schedule and second_lesson_title in schedule:
            first_index = schedule.index(first_lesson_title)
            second_index = schedule.index(second_lesson_title)

            if second_lesson_title + "-Exercise" in schedule:
                schedule[first_index], schedule[second_index] = schedule[second_index], schedule[first_index]
                removed_element = schedule.pop(-1)
                schedule.insert(first_index + 1, removed_element)
            else:
                schedule[first_index], schedule[second_index] = schedule[second_index], schedule[first_index]
    elif command[0] == "Exercise":
        lesson_title = command[1]
        if lesson_title in schedule:
            element_index = schedule.index(lesson_title)
            if element_index + 1 > len(schedule):
                element_index = schedule[-1]
            if lesson_title in schedule[element_index] and lesson_title + "-Exercise" not in schedule:
                schedule.insert(element_index + 1, f"{lesson_title}-Exercise")
        else:
            schedule.append(f"{lesson_title}")
            schedule.append(f"{lesson_title}-Exercise")

    command = input()


print("\n".join(f"{i}.{item}" for i, item in enumerate(schedule, start=1)))