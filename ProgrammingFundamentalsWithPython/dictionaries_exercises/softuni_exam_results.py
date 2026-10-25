participants = {}

languages = {}

command = input()

while command != "exam finished":

    participants_submissions = command.split("-")

    if "banned" in participants_submissions:
        username = participants_submissions[0]

        del participants[username]
    else:
        username = participants_submissions[0]
        language = participants_submissions[1]
        points = int(participants_submissions[2])

        if language not in languages:
            languages[language] = 0
        languages[language] += 1

        if username not in participants.keys():
            participants[username] = {language: []}
        if language not in participants[username].keys():
            participants[username][language] = []
        participants[username][language].append(points)
    command = input()

print("Results:")
for participant, language in participants.items():
    for language_name, points in language.items():
        print(f"{participant} | {max(points)}")
print("Submissions:")
for discipline, count in languages.items():
    print(f"{discipline} - {count}")