using static System.Console;
Clear();
WriteLine("Введите трехзначное число: ");
int a = int.Parse(ReadLine()!);

if (a >= 100 && a <= 999) WriteLine(a%10);
else WriteLine("Число не трехзначное");