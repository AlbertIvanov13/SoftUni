first_match_result = input()
second_match_result = input()
third_match_result = input()

matches_won = 0
matches_lost = 0
draws = 0

if first_match_result[0] > first_match_result[2]:
    matches_won += 1
elif first_match_result[0] < first_match_result[2]:
    matches_lost += 1
else:
    draws += 1

if second_match_result[0] > second_match_result[2]:
    matches_won += 1
elif second_match_result[0] < second_match_result[2]:
    matches_lost += 1
else:
    draws += 1

if third_match_result[0] > third_match_result[2]:
    matches_won += 1
elif third_match_result[0] < third_match_result[2]:
    matches_lost += 1
else:
    draws += 1

print(f"Team won {matches_won} games.")
print(f"Team lost {matches_lost} games.")
print(f"Drawn games: {draws}")