// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
void FillNumber(int[] collection, int min1, int max1)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(min1, max1);
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
int Summa(int[] element)
{
    int length = element.Length;
    int resault = 0;
    for (int i = 1; i < length; i = i + 2)
    {
        resault = resault + element[i];
    }
    return resault;
}


int amount = GetIntFormUser("Введите размер масива");
int[] masiv = new int[amount];
int min = GetIntFormUser("Введите диапозон минимального элемента масива");
int max = GetIntFormUser("Введите диапозон максимального элемента масива");
FillNumber(masiv, min, max);
PrintNumber(masiv);
int answer = Summa(masiv);
Console.WriteLine();
Console.WriteLine(answer + "-сумма элементов стоящих на нечётных позициях");