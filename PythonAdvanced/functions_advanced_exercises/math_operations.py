def math_operations(*args, **kwargs):
    result = []
    current_num = 0
    for arg in args:
        current_num += 1
        if current_num == 1:
            kwargs["a"] += arg
        elif current_num == 2:
            kwargs["s"] -= arg
        elif current_num == 3:
            if arg != 0:
                kwargs["d"] /= arg
        elif current_num == 4:
            kwargs["m"] *= arg
            current_num = 0

    kwargs = dict(sorted(kwargs.items(), key=lambda x: (-x[1], x[0])))

    for key, value in kwargs.items():
        result.append(f"{key}: {value:.1f}")
    return '\n'.join(result)

print(math_operations(6.0, a=0, s=0, d=5, m=0))