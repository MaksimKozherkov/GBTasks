using static System.Console;
Clear();

WriteLine("Введите число N:");
bool isParse = int.TryParse(ReadLine(),out int n);
int i = 1;
if (!isParse) { WriteLine("Введено не число!"); return; }

while (i < n + 1) { WriteLine($"Куб числа {i} равен {Math.Pow(i, 3)}"); i++; }