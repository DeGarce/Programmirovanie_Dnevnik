// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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
void ArrayMasiv(int[] number)
{
    int length = number.Length;
    for (int i = 0; i < length; i++)
    {
        number[i] = GetIntFormUser("Введите " + i + " число");
    }
}
int Check(int[] element)
{
    int length = element.Length;
    int resault = 0;
    for (int i = 0; i < length; i++)
    {
        if (0 > element[i]) resault++;
    }
    return resault;
}





int amount = GetIntFormUser("Введите размер масива");
int[] masiv = new int[amount];
ArrayMasiv(masiv);
int answer=Check(masiv);
Console.WriteLine();
Console.WriteLine(answer + "-количество чисел больше 0");


