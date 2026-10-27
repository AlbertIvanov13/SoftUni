path_to_file = input().split("\\")

file = path_to_file[-1].split(".")

file_name = file[0]
file_extension = file[1]

print(f"File name: {file_name}")
print(f"File extension: {file_extension}")