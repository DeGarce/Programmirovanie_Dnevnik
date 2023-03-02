//Напишите метод, который задаёт массив из N элементов и выводит их на экран.
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
void FillNumber(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 1000);
        index++;
    }
}



int amount = GetIntFormUser("Введите размер масива");
int[] masiv = new int[amount];
FillNumber(masiv);
PrintNumber(masiv);