# Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
def power(number, extent):
    if (extent == 1):
        return (number)
    if (extent != 1):
        return (number * power(number, extent - 1))


number = int(input("Введите число: "))
extent = int(input("Введите его степень: "))
print("Результат ", power(number, extent))
