using static System.Console;

Clear();

WriteLine("Является ли число четным?");

Write("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a % 2 == 0)
{
    Write("Четное");
}
else
{
Write("Не четное");
}