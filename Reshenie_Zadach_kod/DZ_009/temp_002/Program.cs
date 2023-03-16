// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int GetIntFormUser(string text)
{
    int num = 0;
    bool flag = true;
    do
    {
        Console.Write($"{text}:  ");
        flag = int.TryParse(Console.ReadLine(), out num);
    } while (!flag);
    return num;
}
int SummaNumber(int min1, int max1)
{
    if (min1 > max1) return 0;
    else return min1 + SummaNumber(min1 + 1, max1);
}

int min = GetIntFormUser("Введите число M");
int max = GetIntFormUser("Введите число N");
Console.WriteLine(SummaNumber(min, max));