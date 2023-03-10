// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
void Sorting(int[,] number)
{
    int lengthLines = number.GetLength(0);
    int lengthColums = number.GetLength(1);
    int temp;
    for (int i = 0; i < lengthLines; i++)
    {
        for (int t = 0; t < lengthColums; t++)
        {
            temp = t;
            for (int j = t; j < lengthColums; j++)
            {
                if (number[i, j] > number[i, temp])
                {
                    temp = j;
                }
            }
            if (number[i, temp] == number[i, t]) { }
            else
            {
                int variable = number[i, t];
                number[i, t] = number[i, temp];
                number[i, temp] = variable;
            }
        }
    }
}

int amountLines = GetIntFormUser("Введите количество строк");
int amountColumns = GetIntFormUser("Введите количество столбцов");
int min = GetIntFormUser("Введите минимальный элемент");
int max = GetIntFormUser("Введите максимальный элемент");
int[,] masiv = new int[amountLines, amountColumns];
FillNumber(masiv, min, max);
PrintNumber(masiv);
Sorting(masiv);
Console.WriteLine();
Console.WriteLine();
PrintNumber(masiv);