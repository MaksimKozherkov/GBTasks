using static System.Console;

WriteLine("Введите число: ");

int a = int.Parse(ReadLine()!);
//int b = Convert.ToInt32(Read.Line());
WriteLine($"Квадарат числа {a} равен {a*a}");