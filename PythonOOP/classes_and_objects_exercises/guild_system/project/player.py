class Player:
    def __init__(self, name: str, hp: int, mp: int):
        self.name = name
        self.hp = hp
        self.mp = mp
        self.skills: dict = {}
        self.guild = "Unaffiliated"

    def add_skill(self, skill_name: str, mana_cost: int) -> str:
        if skill_name not in self.skills:
            self.skills[skill_name] = mana_cost
            return f"Skill {skill_name} added to the collection of the player {self.name}"
        return "Skill already added"

    def player_info(self) -> str:
        result = ""
        result += f"Name: {self.name}\n"
        result += f"Guild: {self.guild}\n"
        result += f"HP: {self.hp}\n"
        result += f"MP: {self.mp}\n"
        for skill, cost in self.skills.items():
            result += f"==={skill} - {cost}\n"
        return result