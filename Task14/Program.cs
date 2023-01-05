using static System.Console;
Clear();

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);
WriteLine(a==b*b?$"{a} является квадаратом {b}":b==a*a?$"{b} является квадратом {a}":"Ни одно из чисел не является корнем другого!");