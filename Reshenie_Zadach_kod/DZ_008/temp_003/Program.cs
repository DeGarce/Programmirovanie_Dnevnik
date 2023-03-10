// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.Массив размером 2 x 2 x 2
void FillNumber(int[,,] collection)
{
    int lengthLines = collection.GetLength(0);
    int lengthColums = collection.GetLength(1);
    int index = collection.GetLength(2);
    for (int i = 0; i < lengthLines; i++)
    {
        for (int j = 0; j < lengthColums; j++)
        {
            for (int t = 0; t < index; t++)
            {
                collection[i, j, t] = new Random().Next(10, 99);
            }
        }
    }
}
void PrintNumber(int[,,] col)
{
    int lengthLines = col.GetLength(0);
    int lengthColums = col.GetLength(1);
    int index = col.GetLength(2);
    for (int i = 0; i < lengthLines; i++)
    {
        for (int j = 0; j < lengthColums; j++)
        {
            for (int t = 0; t < index; t++)
            {
                Console.Write(col[i, j, t] + " " + (i, j, t));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] masiv = new int[2, 2, 2];
FillNumber(masiv);
PrintNumber(masiv);















