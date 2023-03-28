// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
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
void PrintNumber(int collection)
{
    if (collection > 0)
    {
        Console.WriteLine(collection);
        PrintNumber(collection - 1);
    }
}

int amount = GetIntFormUser("Введите число N");
PrintNumber(amount);









