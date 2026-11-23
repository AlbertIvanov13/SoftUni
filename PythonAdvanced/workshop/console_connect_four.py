class InvalidColumnException(Exception):
    pass

class FullColumnException(Exception):
    pass

def create_board(rows, cols):
    return [[0 for _ in range(0, cols)]for _ in range(rows)]

def print_board(brd):
    print(*board, sep='\n')

def validate_column_choice(col, max_index):
    if col < 0 or col > max_index:
        raise InvalidColumnException("Please insert a valid column number.")

def place_player_choice(matrix, c, player_num):
    for r in range(len(matrix) - 1, -1, -1):
        if matrix[r][c] == 0:
            matrix[r][c] = player_num
            return r, c
    raise FullColumnException

def is_player_number(ma, r, c, player_num):
    if r < 0 or c < 0 or r >= len(ma) or c >= len(ma[0]):
        return False
    return ma[r][c] == player_num

def is_vertical_winner(ma, r, c, player_num, slots):
    return all(is_player_number(ma, r + idx, c, player_num) for idx in range(slots))

def is_horizontal_winner(ma, r, c, player_num, slots):
    filled = 1
    for idx in range(1, slots):
        if is_player_number(ma, r, c + idx, player_num):
            filled += 1
        else:
            break

    for idx in range(1, slots):
        if is_player_number(ma, r, c - idx, player_num):
            filled += 1
        else:
            break

    return filled >= slots

def is_right_diagonal_winner(ma, r, c, player_num, slots):
    filled = 1
    for idx in range(1, slots):
        if is_player_number(ma, r - idx, c + idx, player_num):
            filled += 1
        else:
            break

    for idx in range(1, slots):
        if is_player_number(ma, r + idx, c - idx, player_num):
            filled += 1
        else:
            break

    return filled >= slots

def is_left_diagonal_winner(ma, r, c, player_num, slots):
    filled = 1
    for idx in range(1, slots):
        if is_player_number(ma, r - idx, c - idx, player_num):
            filled += 1
        else:
            break

    for idx in range(1, slots):
        if is_player_number(ma, r + idx, c + idx, player_num):
            filled += 1
        else:
            break

    return filled >= slots

def is_winner(ma, r, c, player_num, slots = 4):
    return any([
        is_vertical_winner(ma, r, c, player_num, slots),
        is_horizontal_winner(ma, r, c, player_num, slots),
        is_right_diagonal_winner(ma, r, c, player_num, slots),
        is_left_diagonal_winner(ma, r, c, player_num, slots)
    ])

rows_count = 6
cols_count = 7

board = create_board(rows_count, cols_count)
print_board(board)

current_player = 1

counter = 0
while True:
    try:
        column_num = int(input(f"Player {current_player}, please choose a column: ")) - 1
        validate_column_choice(column_num, cols_count - 1)
        row, col = place_player_choice(board, column_num, current_player)
        print_board(board)

        if is_winner(board, row, col, current_player):
            print(f"The winner is {current_player}")
            break

        counter += 1
        if rows_count * cols_count == counter:
            print("The game is draw!")
            break

        current_player = 2 if current_player == 1 else 1
    except FullColumnException:
        print("This column is full. Please select another column.")
        continue
    except InvalidColumnException:
        print(f"Select a valid column number (between 1 and {cols_count})")
        continue
    except ValueError:
        print("This is not a digit! Please try again.")
        continue