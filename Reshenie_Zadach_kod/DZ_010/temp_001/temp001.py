#Найдите сумму цифр трехзначного числа.
number = int(input("введите трёхзначное число "))
tempA = int(number % 10)
number = int(number / 10)
tempB = int(number % 10)
tempC = int(number / 10)
print(tempA+tempB+tempC)
