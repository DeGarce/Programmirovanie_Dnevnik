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
void FillingWordsUser(string[] value)
{
    for (int i = 0; i < value.Length; i++)
    {
        Console.WriteLine("Введите " + i + " значение");
        value[i] = Console.ReadLine();
    }
}
string[] CheckingSymbols(string[] symbols)
{
    string temp;
    string[] element = new string[symbols.Length];
    for (int i = 0; i < symbols.Length; i++)
    {
        temp = symbols[i];
        if (temp.Length <= 3)
        {
            element[i] = temp;
        }
    }
    return element;
}
void PrintString(string[] col)
{
    string temp;
    for (int i = 0; i < col.Length; i++)
    {
        temp = col[i];
        if (temp.Length > 0)
        {
            Console.Write(temp + ",");
        }
    }
}



int number = GetIntFormUser("Введите длинну масива");
string[] words = new string[number];
string[] elements = new string[number];
FillingWordsUser(words);
elements = CheckingSymbols(words);
PrintString(elements);
