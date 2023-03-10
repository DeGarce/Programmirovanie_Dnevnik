// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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
void PrintPositionUser(int[,] position)
{
    int lines = GetIntFormUser("Введите позицию в строке");
    int columns = GetIntFormUser("Введите позицию в столбце");
    int lengthLines = position.GetLength(0);
    int lengthColums = position.GetLength(1);
    if (lines < lengthLines & columns < lengthColums)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(position[lines - 1, columns - 1]);
    }
    else
    {
        Console.WriteLine("Такого числа нет");
    }
}

int amountLines = GetIntFormUser("Введите количество строк");
int amountColumns = GetIntFormUser("Введите количество столбцов");
int min = GetIntFormUser("Введите минимальный элемент");
int max = GetIntFormUser("Введите максимальный элемент");
int[,] masiv = new int[amountLines, amountColumns];
FillNumber(masiv, min, max);
PrintNumber(masiv);
PrintPositionUser(masiv);



