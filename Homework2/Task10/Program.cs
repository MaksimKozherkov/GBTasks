using static System.Console;
Clear();
int number = new Random().Next(100,1000);
WriteLine(number);
WriteLine($"{(number%100)/10}");