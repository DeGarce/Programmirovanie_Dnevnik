//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
void Polindrom(int resault)
{
    int[] masiv = new int(5);
    for (int index = 0; index < 5; index++)
    {
        int[] masiv = resault % 10;
        Console.WriteLine(masiv[0]);

    }
}








Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
Polindrom(number);