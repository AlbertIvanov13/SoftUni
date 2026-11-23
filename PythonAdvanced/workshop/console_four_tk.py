import tkinter as tk
from tkinter import messagebox

class FullColumnException(Exception):
    pass

def create_board(rows, cols):
    return [[0 for _ in range(0, cols)]for _ in range(rows)]

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

def update_ui(labels, r, c, player_num):
    color = "red" if player_num == 1 else "blue"
    labels[r][c].config(bg=color)

def reset_game(ma, labels):
    for r in range(len(ma)):
        for c in range(len(ma[0])):
            ma[r][c] = 0
            labels[r][c].config(bg="white")

def handle_click(ma, labels, col_num, player_num, counter, rows, cols, slots):
    try:
        row, col_num = place_player_choice(ma, col_num, player_num)
        update_ui(labels, row, col_num, player_num)

        if is_winner(ma, row, col_num, player_num, slots):
            messagebox.showinfo("Winner", f"Player {player_num} wins!")
            reset_game(ma, labels)
            return 1, 0

        counter += 1

        if rows * cols == counter:
            messagebox.showinfo("Game over. The game is draw!")
            reset_game(ma, labels)
            return 1, 0

        return 2 if player_num == 1 else 1, counter
    except FullColumnException:
        messagebox.showerror("Invalid move", "This column is full, try again.")

    return player_num, counter


def create_gui(root, rows, cols, slots):
    matrix = create_board(rows, cols)
    labels = [[tk.Label(root, text=" ", width=4, height=2, relief="solid") for _ in range(cols)] for _ in range(rows)]
    for r in range(rows):
        for c in range(cols):
            labels[r][c].grid(row=r + 1, column=c)

    player_state = {"player_num": 1, "counter": 0}

    def on_click(col_num, p_state):
        p_state["player_num"], player_state["counter"] = handle_click(matrix, labels, col_num, player_state["player_num"], player_state["counter"], rows, cols, slots)


    buttons = [tk.Button(root, text="↓", width=4, height=2, background="yellow",
                         command=lambda c_index=col: on_click(c_index, player_state)
                         ) for col in range(cols)]
    for col, button in enumerate(buttons):
        button.grid(row=0, column=col)


def start_game():
    root = tk.Tk()
    root.title("Connect Four")

    rows, cols, slots_to_win = 6, 7, 4

    create_gui(root, rows, cols, slots_to_win)

    root.mainloop()


if __name__ == '__main__':
    start_game()