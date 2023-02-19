using static System.Console;

Clear();


Write("Введите два неотрицательных числа, через пробел: ");
int[] numbers = Array.ConvertAll(ReadLine()!.Split(new string[] { " ", ", ", ";" }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
if (numbers[0] < 0 || numbers[1] < 0)
{
    Write("Ошибка! Введите неотрицательные числа!");
    return;
}
int result = GetNumbers(numbers[0], numbers[1]);

WriteLine();
WriteLine("Результат:");
WriteLine($"m = {numbers[0]}, n = {numbers[1]} -> A(m, n) = {result}");
WriteLine();

int GetNumbers(int M, int N)
{

    if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 && N == 0)
    {
        return GetNumbers(M - 1, 1);
    }
    else
    {
        return GetNumbers(M - 1, GetNumbers(M, N - 1));
    }
}