tournaments = int(input())
total_points = int(input())

average_points = 0
won_tournaments = 0

for _ in range(tournaments):
    stage = input()
    if stage == 'W':
        total_points += 2000
        average_points += 2000
        won_tournaments += 1
    elif stage == 'F':
        total_points += 1200
        average_points += 1200
    elif stage == 'SF':
        total_points += 720
        average_points += 720

average_points //= tournaments
won_tournaments /= tournaments

print(f"Final points: {total_points}")
print(f"Average points: {average_points}")
print(f"{won_tournaments * 100:.2f}%")