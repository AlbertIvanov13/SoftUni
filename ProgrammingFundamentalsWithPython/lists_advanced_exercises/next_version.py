version_of_software = list(map(int, input().split(".")))

for i in range(len(version_of_software) - 1, -1, -1):
    if version_of_software[i] + 1 > 9:
        if i == len(version_of_software) - 1:
             version_of_software[i] = 0
             continue
        else:
            version_of_software[i] = 0
    else:
        version_of_software[i] = version_of_software[i] + 1
        break

print(".".join(map(str, version_of_software)))