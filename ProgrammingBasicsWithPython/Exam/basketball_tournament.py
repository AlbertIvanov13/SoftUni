won_matches = 0
lost_matches = 0

total_matches = 0

while True:
    name_of_tournament = input()

    if name_of_tournament == "End of tournaments":
        break

    matches_count = int(input())

    total_matches += matches_count

    for match_number in range(1, matches_count + 1):
        home_team_points = int(input())
        away_team_points = int(input())

        if home_team_points > away_team_points:
            print(f"Game {match_number} of tournament {name_of_tournament}: win with {home_team_points - away_team_points} points.")
            won_matches += 1
        else:
            print(f"Game {match_number} of tournament {name_of_tournament}: lost with {away_team_points - home_team_points} points.")
            lost_matches += 1

print(f"{won_matches / total_matches * 100:.2f}% matches win")
print(f"{lost_matches / total_matches * 100:.2f}% matches lost")