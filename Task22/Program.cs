using static System.Console;

Clear();
WriteLine("Input number1: ");
int number1 = int.Parse(ReadLine()!);

int sum1 = GetSum(number1);
WriteLine($"Sum namber 1..A = {sum1}");

WriteLine("Input number2: ");
int number2 = int.Parse(ReadLine()!);

int sum2 = GetSum(number2);
WriteLine($"Sum namber 1..A = {sum2}");






int GetSum(int A)
{
    int result = 0;
    while (A > 0)
    {
        result += A;
        A--;
    }

    return result;
}