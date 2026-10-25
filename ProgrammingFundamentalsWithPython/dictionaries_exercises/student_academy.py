students = {}

number_of_rows = int(input())

for _ in range(number_of_rows):

    student_name = input()
    grade = float(input())

    if student_name not in students.keys():
        students[student_name] = []
    students[student_name].append(grade)

for student, grades in students.items():
    average_grade = sum(grades) / len(grades)
    if average_grade >= 4.50:
        print(f"{student} -> {average_grade:.2f}")