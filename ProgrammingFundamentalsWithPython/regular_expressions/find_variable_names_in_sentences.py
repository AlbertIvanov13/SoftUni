import re

string = input()
pattern= r"\b_([A-Za-z0-9]+)\b"
variables = re.findall(pattern, string)

print(",".join(variables))