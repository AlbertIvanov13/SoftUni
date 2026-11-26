from project.player import Player

class Guild:
    def __init__(self, name: str):
        self.name = name
        self.players: list[Player] = []

    def assign_player(self, player: Player) -> str:
        p = next((pl for pl in self.players if pl.name == player.name), None)
        if p:
            return f"Player {p.name} is already in the guild."
        if player.guild != "Unaffiliated":
            return f"Player {player.name} is in another guild."
        self.players.append(player)
        player.guild = self.name
        return f"Welcome player {player.name} to the guild {self.name}"

    def kick_player(self, player_name: str) -> str:
        p = next((pl for pl in self.players if pl.name == player_name), None)
        if p:
            self.players.remove(p)
            p.guild = "Unaffiliated"
            return f"Player {player_name} has been removed from the guild."
        return f"Player {player_name} is not in the guild."

    def guild_info(self) -> str:
        result = ""
        result += f"Guild: {self.name}\n"
        for p in self.players:
            result += f"{p.player_info()}\n"
        return result