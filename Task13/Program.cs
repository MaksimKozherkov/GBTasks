using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
WriteLine($"{a}");
WriteLine(a%7==0 && a%23==0?$"Число {a} кратно 7 и 23!":$"Число {a} не кратно 7 или 23!");
