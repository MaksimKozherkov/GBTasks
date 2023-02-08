using static System.Console;

Clear();

int a = AskUser("Введите сторону треугольника a: ");
int b = AskUser("Введите сторону треугольника b: ");
int c = AskUser("Введите сторону треугольника c: ");

WriteLine(IsTriangle(a, b, c) ? $"Треугольник со сторонами {a}, {b} и {c} существует." : $"Треугольник со сторонами {a}, {b} и {c} не существует.");

bool IsTriangle(int InA, int InB, int inC)//проверяет введенные данные на заданные условия
{
    return (a + b > c && a + c > b && b + c > a);
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




