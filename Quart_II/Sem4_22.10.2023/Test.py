
# nums = [3,2,4]
# target = 6

# result = list()

# for el in nums:
#     if target - el in nums:
#         result.append(nums.index(el))
#         result.append(nums.index(target - el))
#         break

# print(result)


# -------------------------------------------------------------ROMAN_TO_INT--------------------------------------------------------------------------

# Symbol       Value
# I             1
# V             5
# X             10
# L             50
# C             100
# D             500
# M             1000

# I можно поставить перед (5) и (10), чтобы получить 4 и 9. VX
# X можно поставить перед (50) и (100), чтобы получить 40 и 90. LC
# C Можно поставить перед (500) и (1000), чтобы получить 400 и 900.DM

# s содержит только символы .('I', 'V', 'X', 'L', 'C', 'D', 'M')

# Дана римская цифра, преобразуйте ее в целое число.

s = "MCMXCIV"
s = [el for el in s]
result = 0
 # "MDCCCLXXXIV"        
# M     1000
# D     500
# CCC   300 (100 + 100 + 100)
# L     50
# XXX   30 (10 + 10 + 10)
# IV    4 (5 - 1)
# 
# 
# 
# 

alphabet = {
            'I': 1, 
            'V': 5, 
            'X': 10, 
            'L': 50, 
            'C': 100, 
            'D': 500, 
            'M': 1000
            }

is_minus = False
index = 1
in_mind = 0

for letter in s:
    if is_minus:
        result += alphabet[letter] - in_mind
        is_minus = False
        in_mind = 0


    elif letter == 'I' and index < len(s):

        in_mind += alphabet[letter]
        if s[index] == 'V' or s[index] == 'X' and not is_minus:
            is_minus = True
        else:
            result += in_mind
            in_mind = 0

    elif letter == 'X' and index < len(s):

        in_mind += alphabet[letter]
        if s[index] == 'L' or s[index] == 'C' and not is_minus:
            is_minus = True
        else:
            result += in_mind
            in_mind = 0

    elif letter == 'C' and index < len(s):

        in_mind += alphabet[letter]
        if s[index] == 'D' or s[index] == 'M' and not is_minus:
            is_minus = True
        else:
            result += in_mind
            in_mind = 0

    else:
        result += alphabet[letter]
        
    index += 1
result += in_mind
print(result)





        # print(f"{result} \n #minus  {result} += {alphabet[letter]} - {in_mind} ")






        # print(f"{result} \n #1  {in_mind} += {alphabet[letter]} ")









        # print(f"{result} \n #2  {in_mind} += {alphabet[letter]} ")









        # print(f"{result} \n #3  {in_mind} += {alphabet[letter]} ")









        # print(f"{result} \n #else   {result} += {alphabet[letter]} ")




# return result