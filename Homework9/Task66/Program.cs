using static System.Console;

Clear();


Write("Введите первое и второе число через пробел: ");
string[] par = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
int M = int.Parse(par[0]);
int N = int.Parse(par[1]);

WriteLine();
WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}:");
WriteLine();
Write($"M = {M}; N = {N} -> ");
WriteLine(SumNumbers(M, N));
WriteLine();

int SumNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        int temp = numberM;
        numberM = numberN;
        numberN = temp;
    }
    if (numberM == numberN) return numberM;
    else
    {
        return SumNumbers(numberM + 1, numberN) + numberM;
    }
}