def loading_bar(number: int) -> str:

    if number == 100:
        return "100% Complete!\n[%%%%%%%%%%]"

    percents_count = number // 10
    dots_count = 10 - percents_count
    return f"{number}% [{'%' * percents_count}{'.' * dots_count}]\nStill loading..."

integer = int(input())

result = loading_bar(integer)

print(result)