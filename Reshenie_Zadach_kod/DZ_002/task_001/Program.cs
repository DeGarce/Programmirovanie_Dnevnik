//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void FillNumber(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}
void PrintNumber(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
void FillResult(int[] array)
{
    int variable = array.Length;
    int index = 0;
    while (index < variable)
    {
        int numbers = array[index];
        int a = numbers % 100;
        int b = a / 10;
        array[index] = b;
        index++;
    }
}
int[] number = new int[10];

FillNumber(number);
PrintNumber(number);

Console.WriteLine();
Console.WriteLine();

FillResult(number);
PrintNumber(number);