using static System.Console;

Clear();

int a = AskUser("Введите сторону треугольника a: ");
int b = AskUser("Введите сторону треугольника b: ");
int c = AskUser("Введите сторону треугольника c: ");

WriteLine(IsTriangle(a, b, c) ? $"Треугольник со сторонами {a}, {b} и {c} существует." : $"Треугольник со сторонами {a}, {b} и {c} не существует.");

bool IsTriangle(int InA, int InB, int InC)//проверяет введенные данные на заданные условия
{
    return (InA + InB > InC && InA + InC > InB && InB + InC > InA);
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




