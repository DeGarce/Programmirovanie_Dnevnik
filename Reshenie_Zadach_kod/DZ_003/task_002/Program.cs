//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Record(int[] coordinates)
{
    int length = coordinates.Length;
    for (int index = 0; index < length; index++)
    {
        coordinates[index] = int.Parse(Console.ReadLine()!);
    }
}
void Resault(int[] coorA, int[] coorB)
{
    double number;
    number = Math.Sqrt(Math.Pow((coorA[0] - coorB[0]), 2) + Math.Pow((coorA[1] - coorB[1]), 2) + Math.Pow((coorA[2] - coorB[2]), 2));
    Console.WriteLine("Расстояние между точками");
    Console.WriteLine("{0: 0.00}", number);
}

Console.WriteLine("Введите кординаты точек");
int[] dotA = new int[3];
int[] dotB = new int[3];
Console.WriteLine("A");
Record(dotA);
Console.WriteLine("B");
Record(dotB);
Resault(dotA, dotB);