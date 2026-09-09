deposit_sum = float(input())
deposit_expiration = int(input())
annual_interest_rate = float(input())

total_sum = deposit_sum + deposit_expiration * ((deposit_sum * annual_interest_rate / 100) / 12)

print(total_sum)