using static System.Console;
Clear();

WriteLine("Введите число:");
int number = int.Parse(ReadLine()!);

WriteLine(number>99?(number%1000)/100:"Третьей цифры в заданном числе нет");