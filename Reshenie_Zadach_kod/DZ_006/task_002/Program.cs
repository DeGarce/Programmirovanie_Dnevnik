// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double GetIntFormUser(string text)
{
    double num = 0;
    bool flag = true;
    do
    {
        Console.Write($"{text}:  ");
        flag = double.TryParse(Console.ReadLine(), out num);
    } while (!flag);
    return num;
}
void PrintNumber(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + "  ");
        position++;
    }
}
void ArrayMasiv(double[] number)
{
    number[0] = GetIntFormUser("Введите значение b1");
    number[1] = GetIntFormUser("Введите значение b2");
    number[2] = GetIntFormUser("Введите значение k1");
    number[3] = GetIntFormUser("Введите значение k2");
}
double[] FindingPoint(double[] element)
{
    double[] resault = new double[2];
    resault[0] = element[1] - element[0];
    resault[1] = element[2] - element[3];
    double answer = resault[0] / resault[1];
    resault[0] = element[2] * answer + element[0];
    resault[1] = element[3] * answer + element[1];
    return resault;
}

double[] masiv = new double[4];
ArrayMasiv(masiv);
double[] a = new double[2];
a = FindingPoint(masiv);
PrintNumber(a);










