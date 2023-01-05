using static System.Console;
Clear();

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);
WriteLine($"{a}, {b}");
// WriteLine(b%a==0?"Число b кратно числу a.":b%a);
WriteLine(a==b?"=":a<b?"<":">");