// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
void FillNumber(int[,] collection, int min1, int max1)
{
    int lengthLines = collection.GetLength(0);
    int lengthColums = collection.GetLength(1);
    for (int i = 0; i < lengthLines; i++)
    {
        for (int j = 0; j < lengthColums; j++)
        {
            collection[i, j] = new Random().Next(min1, max1);
        }
    }
}
void PrintNumber(int[,] col)
{
    int lengthLines = col.GetLength(0);
    int lengthColums = col.GetLength(1);
    for (int i = 0; i < lengthLines; i++)
    {
        for (int j = 0; j < lengthColums; j++)
        {
            Console.Write(col[i, j] + " ");

        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
void AverageScore(int[,] number)
{
    int lines = number.GetLength(0);
    int columns = number.GetLength(1);
    double summa = 0;
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < lines; j++)
        {
            summa = summa + number[j, i];
        }
        summa = summa / lines;
        Console.Write("{0: 0.00}", summa);
        Console.Write(" - Среднее арифметическое " + (i + 1) + " столбца");
        Console.WriteLine();
        summa = 0;
    }
}

int amountLines = GetIntFormUser("Введите количество строк");
int amountColumns = GetIntFormUser("Введите количество столбцов");
int min = GetIntFormUser("Введите минимальный элемент");
int max = GetIntFormUser("Введите максимальный элемент");
int[,] masiv = new int[amountLines, amountColumns];
FillNumber(masiv, min, max);
PrintNumber(masiv);
AverageScore(masiv);

