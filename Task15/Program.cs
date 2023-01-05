using static System.Console;
Clear();

WriteLine("Первый стрелок сбил: ");
int a = int.Parse(ReadLine()!);
WriteLine("Второй стрелок сбил: ");
int b = int.Parse(ReadLine()!);
WriteLine("1 банку они сбили вместе");
WriteLine($"Всего было {a+b-1} банок");