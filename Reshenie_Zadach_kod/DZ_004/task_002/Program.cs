//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
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
int Division(int meaning)
{
    string variable = meaning.ToString();
    int value = 0;
    int resault = 0;
    for (int i = 0; i < variable.Length; i++)
    {
        value = meaning % 10;
        resault = value + resault;
        meaning = meaning / 10;
    }
    return resault;
}

int number = GetIntFormUser("Введите число");
int a = Division(number);
Console.WriteLine(a);










