// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int[] AdditionElements(int[,] number)
{
    int lines = number.GetLength(0);
    int columns = number.GetLength(1);
    int summa = 0;
    int[] variable = new int[lines];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            summa = summa + number[i, j];
        }
        variable[i] = summa;
        summa=0;
    }
    return variable;
}
void ComparisonResults(int [] answer)
{
    int length=answer.Length;
    int temp=0;
    int element=0;
    for (int i = 0; i < length; i++)
    {
        if(answer[i]<answer[temp])
        {
          temp=i;
          element=answer[i];
        }
    }
    Console.WriteLine(temp +"-строка с суммой "+element);
}

int amountLines = GetIntFormUser("Введите количество строк");
int amountColumns = GetIntFormUser("Введите количество столбцов");
int min = GetIntFormUser("Введите минимальный элемент");
int max = GetIntFormUser("Введите максимальный элемент");
int[,] masiv = new int[amountLines, amountColumns];
int [] resault=new int[amountLines];
FillNumber(masiv, min, max);
PrintNumber(masiv);
resault = AdditionElements(masiv);
ComparisonResults(resault);
