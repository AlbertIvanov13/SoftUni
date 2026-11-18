import os

directory = "../"

files = {}

for element in os.listdir(directory):
    f = os.path.join(directory, element)
    if os.path.isfile(f):
        extension = element.split(".")[-1]
        if extension not in files:
            files[extension] = []
        files[extension].append(element)
    else:
        for el in os.listdir(f):
            file_name = os.path.join(f, el)
            if os.path.isfile(file_name):
                extension = el.split(".")[-1]
                if extension not in files:
                    files[extension] = []
                files[extension].append(el)

with open(os.path.join(directory, "report.txt"), "w") as output_file:
    for ext, file_names in sorted(files.items()):
        output_file.write("." + ext + "\n")
        for file_name in sorted(file_names):
            output_file.write(f"- - - {file_name}\n")