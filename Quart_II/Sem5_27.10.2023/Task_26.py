# Задача 26: 

# Напишите программу, которая на вход принимает 
# два числа A и B, и возводит число А в целую степень B с 
# помощью рекурсии.

# A = 3; B = 5 -> 243 (3⁵)
# A = 2; B = 3 -> 8


res = 1

def f(num, multy):
    if multy == 0:
        return 1
    return num * f(num, multy - 1)


a = 3
b = 5
print(f(a, b))



