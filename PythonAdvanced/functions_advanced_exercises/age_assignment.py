def age_assignment(*args, **kwargs):
    result = []

    kwargs = dict(sorted(kwargs.items(), key=lambda x: x[0]))

    for letter, age in kwargs.items():
        for name in args:
            if name.startswith(letter):
                result.append(f"{name} is {age} years old.")
                break

    return '\n'.join(result)

print(age_assignment("Peter", "George", G=26, P=19))