using static System.Console;
Clear();

WriteLine("Введите число: ");

int a = int.Parse(ReadLine()!);
int n = 1;

while (n <= a)
{
   if (n % 2 == 0)
   {
     Write($"{n} ");
     n = n + 1;
   }
    else
    {
    n = n + 1;
    }
}