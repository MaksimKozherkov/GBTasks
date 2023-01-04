using static System.Console;
Clear();
WriteLine("Какое число бальше а какое меньше");

Write("Введите число a: ");

int a = int.Parse(ReadLine()!);

Write("Введите число b: ");

int b = int.Parse(ReadLine()!);

if (a > b)
{
    Write($"Число {a} больше числа {b}");
}

else
{
    Write($"Число {b} больше числа {a}");
}