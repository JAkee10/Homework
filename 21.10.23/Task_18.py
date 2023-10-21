# Задача 18:
# Требуется найти в массиве A[1..N] самый близкий по
# величине элемент к заданному числу X. Пользователь в первой строке
# вводит натуральное число N – количество элементов в массиве. В
# последующих строках записаны N целых чисел A. 
# Последняя строка содержит число X

# 5
# 1 2 3 4 5
# 6

# -> 5

# list_1 = [2, 5, 6, 10, 34, 66]


import random

    # ЗАПОЛНЕНИЕ СПИСКА СЛУЧАЙНЫМИ ЧИСЛАМИ:

list_1 = list()
for i in range(int(input(f"Длина списка: "))):
    list_1.append(random.randint(1, 15))

k = int(input(f"Искомое число: "))


max_value = max(list_1)
min_value = min(list_1)

print(list_1)


if list_1.count(k):
    print(f"-> {k}")
elif k < min_value:
    print(f"-> {min_value}")
elif k > max_value:
    print(f"-> {max_value}")
else:

    list_1.sort()
    for i in range(len(list_1)):
        if list_1[i] > k:
            if k >= (list_1[i - 1] + list_1[i]) / 2:
                print(f"-> {list_1[i]}")
                break
            else:
                print(f"-> {list_1[i - 1]}")
                break






# 
                                                        # Version 1.0
# import random

# list_1 = list()
# k = 5

# for i in range(int(input(f"Длина списка: "))):
#     list_1.append(random.randint(1, 15))

# max_value = max(list_1)
# min_value = min(list_1)

# print(list_1)

# if list_1.count(k):
#     print(f"-> {k}")
# elif k < min_value:
#     print(f"-> {min_value}")
# elif k > max_value:
#     print(f"-> {max_value}")
# else:

#     for el in list_1:
#         if 