courses = {}

command = input()

while command != "end":

    current_name = command.split(" : ")
    course_name = current_name[0]
    student_name = current_name[1]

    if course_name not in courses:
        courses[course_name] = []
    courses[course_name].append(student_name)

    command = input()

for course_name, course_list in courses.items():
    print(f"{course_name}: {len(course_list)}")
    for student in course_list:
        print(f"-- {student}")