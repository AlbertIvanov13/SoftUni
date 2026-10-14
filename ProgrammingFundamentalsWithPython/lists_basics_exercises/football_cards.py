teams = input().split()

first_team_players = 11
second_team_players = 11

is_terminated = False

banned_players_first_team = []
banned_players_second_team = []

for team in teams:
    player = team.split('-')
    if player[0] == 'A':
        if player[1] in banned_players_first_team:
            continue
        else:
            banned_players_first_team.append(player[1])
            first_team_players -= 1
    elif player[0] == 'B':
        if player[1] in banned_players_second_team:
            continue
        else:
            banned_players_second_team.append(player[1])
            second_team_players -= 1

    if first_team_players < 7:
        is_terminated = True
        break
    elif second_team_players < 7:
        is_terminated = True
        break

print(f"Team A - {first_team_players}; Team B - {second_team_players}")

if is_terminated:
    print("Game was terminated")