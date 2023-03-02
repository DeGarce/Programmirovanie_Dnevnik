// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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
void FillNumber(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}
void PrintNumber(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + ",");
        position++;
    }
}
int Check(int[] element)
{
    int length = element.Length;
    int resault = 0;
    for (int i = 0; i < length; i++)
    {
        if (element[i] % 2 == 0)
        {
            resault++;
        }
    }
    return resault;
}

int amount = GetIntFormUser("Введите размер масива");
int[] masiv = new int[amount];
FillNumber(masiv);
PrintNumber(masiv);
int even = Check(masiv);
Console.WriteLine();
Console.WriteLine(even + "-Количество чётных чисел");