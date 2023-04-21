# Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X. Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X

n = int(input("Введите размер масива "))
masiv = list()
number = list()
for i in range(n):
    temp = int(input("Вводите числа от одного до 10 в разном порядке "))
    masiv.append(temp)
x = int(input("Введите число "))
x = x+1
for i in range(n):
    x = x-1
    for j in range(n):
        if (x == masiv[j]):
            temp1 = x
            number.append(temp1)
print(number[0])
