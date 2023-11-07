#     Задача 34: 

# Винни-Пух попросил Вас посмотреть, есть ли в его стихах ритм. Поскольку
# разобраться в его кричалках не настолько просто, насколько легко он их придумывает, Вам
# стоит написать программу. 

# Винни-Пух считает, что ритм есть, если число слогов (т.е. число
# гласных букв) в каждой фразе стихотворения одинаковое. Фраза может состоять из одного
# слова, если во фразе несколько слов, то они разделяются дефисами. Фразы отделяются друг
# от друга пробелами. Стихотворение Винни-Пух вбивает в программу с клавиатуры. 
# В ответе напишите “Парам пам-пам”, если с ритмом все в порядке и “Пам парам”, 
# если с ритмом все не в порядке

# Ввод: 
# пара-ра-рам рам-пам-папам па-ра-па-дам 

# Вывод:
# Парам пам-пам

stroka = 'пара-ра-рам рам-пам-папам па-ра-па-дам пара-ра-рам рам-пам-папам па-ра-па-дам'

not_enough_phrase = False
list_of_phrases = stroka.split()
list_of_syllables = []

vowels = ["а", "о", "е", "у", "и", "ё", "ы", "я", "э", "ю"]

if len(list_of_phrases) > 2:
    for phrase in list_of_phrases:
        # syllables_count = 0
        # for letter in phrase:
        #     if letter in vowels_letters:
        #         syllables_count += 1
        # list_of_syllables.append(syllables_count)
        
        list_of_syllables.append(len([letter for letter in phrase if letter in vowels]))
else:
    not_enough_phrase = True


if not_enough_phrase:
    print("Количество фраз должно быть больше одной!")
elif list_of_syllables.count(list_of_syllables[0]) == len(list_of_syllables):
    print("Парам пам-пам")
else:
    print("Пам парам")
















# for i in range(len(list_of_phrases)):
#     syllables = 0
#     for letter in list_of_phrases[i]:
#         if letter in vowels_letters:
#             syllables += 1