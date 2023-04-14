#Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.
n = int(input("Введите число n "))
number = 2
for i in range(n-1):
    number *=2
    print(number)