using static System.Console;
Clear();

int num = AskUser("Введите число для перевода в двоичную систему: ");

WriteLine($"\nДесятичное число {num} в двоичном представлении выглядит так: {decimalToBinary(num)}\n");//\n"текст"\n добавляет межстрочный интервал


string decimalToBinary(int inNum)
{
    string result = string.Empty;
    int rem;

    while (inNum > 0)
    {
        rem = inNum % 2;
        inNum /= 2;
        result = rem.ToString() + result;
    }
    return result;
}











int AskUser(string inAsk)//задает пользователю вопрос и считывает числовой ответ
{
    int resultAsk = 0;
    string userAsk = "";
    while (!int.TryParse(userAsk, out resultAsk))
    {
        Console.Write(inAsk);
        userAsk = Console.ReadLine()!;
    }
    return resultAsk;
}
