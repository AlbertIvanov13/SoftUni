companies = {}

command = input()

while command != "End":

    company_and_employee = command.split(" -> ")

    company_name = company_and_employee[0]
    employee_id = company_and_employee[1]

    if company_name not in companies.keys():
        companies[company_name] = []

    if employee_id not in companies[company_name]:
        companies[company_name].append(employee_id)

    command = input()

for company, employees in companies.items():
    print(f"{company}")
    for employee in employees:
        print(f"-- {employee}")