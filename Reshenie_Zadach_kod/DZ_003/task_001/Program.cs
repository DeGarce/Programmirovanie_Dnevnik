//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
void Polindrom(int resault)
{
    int[] masiv = new int[5];
    for (int index = 0; index < 5; index++)
    {
        masiv[index] = resault % 10;
        resault = resault / 10;
    }
    if (masiv[0] == masiv[4] && masiv[1] == masiv[3]) Console.WriteLine("Это полиндром");
    else Console.WriteLine("Это не полиндром");
}

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
Polindrom(number);