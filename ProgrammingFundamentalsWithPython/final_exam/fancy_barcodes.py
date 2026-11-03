import re

def check_barcode(barcode: str) -> str:

    pattern = r"^@#+(.*)@#+$"
    current_barcode = re.search(pattern, barcode)
    if not current_barcode:
        return "Invalid barcode"
    current_barcode = current_barcode.group(1)

    if len(current_barcode) < 6:
        return "Invalid barcode"
    elif not current_barcode[0].isupper():
        return "Invalid barcode"
    elif not current_barcode.isalnum():
        return "Invalid barcode"
    elif not current_barcode[-1].isupper():
        return "Invalid barcode"

    product_group = ""

    for char in current_barcode:
        if char.isdigit():
            product_group += char

    if product_group == "":
        product_group = "00"
    return f"Product group: {product_group}"

count_of_barcodes = int(input())

for _ in range(count_of_barcodes):

    new_barcode = input()
    result = check_barcode(new_barcode)
    print(result)