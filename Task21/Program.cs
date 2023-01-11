using static System.Console;
Clear();

WriteLine("Введите число N: ");
bool isParse = int.TryParse(ReadLine(),out int n);
int i = 1;
if(!isParse)
{
    WriteLine("Введено не число!");
    return;
}
// Write($"Квадраты чисел от 1 до N: ");
// while (n <= a)
// {
//     Write($"{n*n} ");
//     // Write($"{n*n} ");
//     n = n + 1;
// }
while(i < n + 1)
{
    WriteLine($"Квадрат числа {i} равен {Math.Pow(i,2)}");
    i++;
}