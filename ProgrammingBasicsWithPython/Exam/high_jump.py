target_height = int(input())

starting_height = target_height - 30
failed_tries = 0

no_jumped = True

last_jump = 0
total_jumps = 0

while no_jumped:
    for _ in range(3):
        total_jumps += 1
        new_jump = int(input())
        last_jump = new_jump
        if starting_height == target_height and new_jump > target_height:
            print(f"Tihomir succeeded, he jumped over {target_height}cm after {total_jumps} jumps.")
            no_jumped = False
            failed_tries = 0
            break

        elif new_jump > starting_height:
            starting_height += 5
            failed_tries = 0
        else:
            failed_tries += 1

        if failed_tries == 3:
            print(f"Tihomir failed at {starting_height}cm after {total_jumps} jumps.")
            no_jumped = False
            break