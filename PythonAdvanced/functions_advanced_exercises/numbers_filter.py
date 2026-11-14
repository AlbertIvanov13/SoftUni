def even_odd_filter(**kwargs):
    dictionary = {}
    for key, value in kwargs.items():
        if key == "even":
           even = [int(x) for x in value if int(x) % 2 == 0]
           dictionary["even"] = even
        elif key == "odd":
           odd = [int(x) for x in value if int(x) % 2 != 0]
           dictionary["odd"] = odd
    sorted_dictionary = dict(sorted(dictionary.items(), key=lambda item: len(item[1]), reverse=True))
    return sorted_dictionary

print(even_odd_filter(
    odd=[1, 2, 3, 4, 10, 5],
    even=[3, 4, 5, 7, 10, 2, 5, 5, 2],
))