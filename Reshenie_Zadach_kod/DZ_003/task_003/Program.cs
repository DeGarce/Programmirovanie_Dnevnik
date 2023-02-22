//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Resault(int[] variable)
{
    int length = variable.Length;
    for (int index = 0; index < length; index++)
    {
        variable[index] = index * index * index;

    }
}
void PrintNumber(int[] collection)
{
    int length = collection.Length;
    for (int index = 1; index < length; index++)
    {
        Console.WriteLine(index + "-" + collection[index]);
    }
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int[] a = new int[number + 1];
Resault(a);
PrintNumber(a);