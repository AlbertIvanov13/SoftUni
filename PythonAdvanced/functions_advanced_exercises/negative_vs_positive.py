def negatives_positives(*args):
    neg = sum(num for num in args if num < 0)
    pos = sum(num for num in args if num > 0)
    return neg, pos

numbers = [int(x) for x in input().split()]
negatives, positives = negatives_positives(*numbers)
print(negatives)
print(positives)

if abs(negatives) > positives:
    print("The negatives are stronger than the positives")
else:
    print("The positives are stronger than the negatives")