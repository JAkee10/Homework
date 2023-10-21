# Задача 16:
# Требуется вычислить, сколько раз встречается некоторое
# число X в массиве A[1..N]. Пользователь в первой строке вводит
# натуральное число N – количество элементов в массиве. В последующих 
# строках записаны N целых чисел A. Последняя строка содержит число X

# 5
# 1 2 3 4 5
# 3

# -> 1

import random

list_range = int(input(f"Длина списка: "))
check_number = int(input(f"Число для проверки: "))
num_list = list()

for i in range(list_range):
    num_list.append(random.randint(1, 5))

print()
print(f"{num_list.count(check_number)} раз(а) число {check_number} встречается в списке {num_list}")