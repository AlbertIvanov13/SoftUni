def concatenate(*args, **kwargs):
    result = ""
    for arg in args:
        result += arg

    for key, value in kwargs.items():
        if key in result:
            start_index = result.index(key)
            end_index = len(key)
            item_to_change = result[start_index:start_index + end_index]
            result = result.replace(item_to_change, value)

    return result


print(concatenate("Soft", "UNI", "Is", "Grate", "!", UNI="Uni", Grate="Great"))