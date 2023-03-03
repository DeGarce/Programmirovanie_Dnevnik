// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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
int[] Comparison(int[] element)
{
    int length = element.Length;
    int[] difference = new int[2];
    difference[0] = element[0];
    difference[1] = element[0];
    for (int i = 0; i < length; i++)
    {
        if (difference[0] > element[i]) difference[0] = element[i];
        if (difference[1] < element[i]) difference[1] = element[i];
    }
    return difference;

}
int Summa(int[] number)
{
    int length = number.Length;
    int resault = 0;
    for (int i = 0; i < length; i++)
    {
        resault = number[i] - resault;
    }
    return resault;
}


int amount = GetIntFormUser("Введите размер масива");
int[] masiv = new int[amount];
int min = GetIntFormUser("Введите диапозон минимального элемента масива");
int max = GetIntFormUser("Введите диапозон максимального элемента масива");
FillNumber(masiv, min, max);
PrintNumber(masiv);
int[] resault = new int[2];
resault = Comparison(masiv);
int answer = Summa(resault);
Console.WriteLine();
Console.WriteLine(answer + "-разница между минимальным и максимальным элементов");





