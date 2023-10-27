# Задача 28: 

# Напишите рекурсивную функцию sum(a, b),
# возвращающую сумму двух целых неотрицательных чисел. Из
# всех арифметических операций допускаются только +1 и -1.
# Также нельзя использовать циклы.

# 2 2
# 4



def sum(a, b):
    if b > 0:
        return sum(a + 1, b - 1)
    return a


a = 2
b = 2
print(sum(a, b))

