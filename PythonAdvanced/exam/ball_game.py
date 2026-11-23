from collections import deque

strengths = list(map(int, input().split()))
accuracies = deque(map(int, input().split()))

scored_goals = 0

while strengths and accuracies:
    result = strengths[-1] + accuracies[0]

    if result == 100:
        strengths.pop()
        accuracies.popleft()
        scored_goals += 1
    elif result < 100:
        if strengths[-1] < accuracies[0]:
            strengths.pop()
        elif strengths[-1] > accuracies[0]:
            accuracies.popleft()
        elif strengths[-1] == accuracies[0]:
            strengths.pop()
            strengths.append(result)
            accuracies.popleft()
    elif result > 100:
        new_strength = strengths.pop() - 10
        strengths.append(new_strength)
        accuracies.append(accuracies.popleft())

if scored_goals == 3:
    print("Paul scored a hat-trick!")
elif scored_goals == 0:
    print("Paul failed to score a single goal.")
elif scored_goals > 3:
    print("Paul performed remarkably well!")
elif 0 < scored_goals < 3:
    print("Paul failed to make a hat-trick.")

if scored_goals > 0:
    print(f"Goals scored: {scored_goals}")

if strengths:
    print(f"Strength values left: {', '.join(map(str, strengths))}")
if accuracies:
    print(f"Accuracy values left: {', '.join(map(str, accuracies))}")