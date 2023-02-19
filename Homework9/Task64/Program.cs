using static System.Console;

Clear();


Write("Введите целое число: ");
bool isNumber = int.TryParse(ReadLine(), out int Number);
if (!isNumber)
{
    WriteLine("Ошибка! Вы ввели не число! Попробуйте снова.");
    return;
}

WriteLine();
WriteLine($"Все натуральные числа в промежутке от {Number} до 1:");
WriteLine();
Write($"N = {Number} -> \"");
PrintNaturalNumbers(Number);
WriteLine("\"");
WriteLine();




void PrintNaturalNumbers(int num)       // рекурсивный метод вывода натуральных чисел
{
    if (num > 0)
    {
        if (num == 1)
        {
            Write(num);
        }
        else
        {
            Write($"{num}, ");
            PrintNaturalNumbers(num - 1);
        }
    }
    else
    {
        if (num == 1)
        {
            Write(num);
        }
        else
        {
            Write($"{num}, ");
            PrintNaturalNumbers(num + 1);
        }
    }
}