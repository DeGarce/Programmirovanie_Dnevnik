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
void FillingWordsUser(string [] value)
{
    for (int i = 0; i < value.Length; i++)
    {
       Console.WriteLine("Введите "+ i + " значение");
        value[i] = Console.ReadLine();
    }
}









int number = GetIntFormUser("Введите длинну масива");
string [] words= new string [number];
FillingWordsUser(words);