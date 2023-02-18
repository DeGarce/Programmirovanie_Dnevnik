//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void PrintResult(int wek)
{
    string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    Console.Write(day[wek - 1]);
    if (wek == 6 || wek == 7) Console.Write("-УРА ВЫХОДНОЙ");
}

Console.WriteLine("Введите число от 1 до 7");
int element = int.Parse(Console.ReadLine()!);

PrintResult(element);

