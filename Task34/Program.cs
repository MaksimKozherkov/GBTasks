using static System.Console;

Clear();

int ticket = AskUser("Введите номер билета: ");
WriteLine(LuckyTicket(ticket) ? $"\nБилет с номером {ticket} счастливый." : $"Билет с номером {ticket} не счастливый.\n");
// LuckyTicket(ticket);

bool LuckyTicket(int inNum)
{
    //123456
    //abcdef
    int a = inNum / 100000;
    int b = (inNum / 10000) % 10;
    int c = (inNum / 1000) % 10;
    int d = (inNum % 1000) / 100;
    int e = (inNum / 10) % 10;
    int f = inNum % 10;
    WriteLine($"{a} {b} {c} {d} {e} {f}");
    return (a + b + c == d + e + f); //вместо if формула вернет true или false
}

// bool LuckyTicket(string inString)
// {
//     foreach (var item in inString)
//     {
//         WriteLine(Convert.ToInt32(item));
//     }
//     return false;
// }

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
