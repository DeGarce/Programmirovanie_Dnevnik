#Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались за проезд и получали билет с номером. 
#Счастливым билетом называют такой билет с шестизначным номером, где сумма первых трех цифр равна сумме последних трех. Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6. 
#Вам требуется написать программу, которая проверяет счастливость билета.
number = int(input("Введите шестизначное число "))
tempA = int(number % 10)
number = int(number / 10)
tempB = int(number % 10)
number = int(number / 10)
tempC = int(number % 10)
number = int(number / 10)
tempD = int(number % 10)
number = int(number / 10)
tempF = int(number % 10)
number = int(number / 10)
tempG = int(number % 10)
number = int(number / 10)
if tempA+tempB+tempC==tempD+tempF+tempG:
    print("это счастливый билет")
else:
    print("это не счастливый билет")

