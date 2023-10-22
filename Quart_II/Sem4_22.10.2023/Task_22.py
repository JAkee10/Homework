# Задание 22

# Даны два неупорядоченных набора целых чисел (может быть, с повторениями). Выдать без повторений в порядке возрастания все те числа, 
# которые встречаются в обоих наборах.
# На вход подается 2 числа через пробел: n m
# n - кол-во элементов первого множества.
# m - кол-во элементов второго множества.
# Затем подаются элементы каждого множества через пробел в виде строки. ! Писать input() не надо

# Input:
# var1 = '5 4'              количество элементов первого и второго множества
# var2 = '1 3 5 7 9'        элементы первого множества через пробел
# var3 = '2 3 4 5'          элементы второго множества через пробел

# Output -> 3 5

var1 = '5 5'
var2 = '10 20 200 40 50'
var3 = '10 20 200 40 50'

size = var1.split()    # var1    #input(f"Размер наборов через пробел: ").split()
variety_1 = set(var2.split())    # var2    #set(input(f"Последовательность чисел через пробел: ").split())
variety_2 = set(var3.split())    # var3    #set(input(f"Последовательность чисел через пробел: ").split())

intersection_numbers = list(variety_1.intersection(variety_2))
num_list = [int(el) for el in intersection_numbers]
num_list.sort()
for el in num_list:
    print(el, end= ' ')





# print(intersection_numbers, type(intersection_numbers))

# print(variety_1, variety_2, "\n\n", intersection_numbers)