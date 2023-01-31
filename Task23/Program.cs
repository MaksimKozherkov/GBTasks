using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);

int work = GetWork(number);
WriteLine($"Произведение чисел от 1 до {number} равно {work}.");









int GetWork(int A)
{
    int result = 1;
    while (A>0)
    {
        result *= A;
        A--;
    }
    return result;
}