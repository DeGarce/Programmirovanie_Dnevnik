//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int check2(int meaning)
{
    int index = 0;
    while (6 > index)
    {
        if (meaning / 1000 == 0)
        {
            index = index + 11;
        }
        else
        {
            meaning = meaning / 10;
        }
    }
    int number = meaning;
    return number;
}
void PrintAnswer(int col)
{
    if (100 > col)
    {
        Console.WriteLine("Третьей цифры нету");
    }
    else
    {
        int first = col % 100;
        int second = first % 10;
        Console.WriteLine(second);
    }
}

Console.WriteLine("введите любое число до  999 999 999");
int number = int.Parse(Console.ReadLine()!);
int result = check2(number);
PrintAnswer(result);