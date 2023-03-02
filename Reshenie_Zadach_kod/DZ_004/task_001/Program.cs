//Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.нельзя использовать Math.Pow
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
int Exponentiation(int value, int factor)
{
    int result = 1;
    for (int i = 0; i < factor; i++)
    {
        result = result * value;
    }
    return result;
}

int number = GetIntFormUser("Введите число");
int exstent = GetIntFormUser("Введите степень");
int answer = Exponentiation(number, exstent);
Console.WriteLine(answer);