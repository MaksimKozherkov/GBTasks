using static System.Console;

Clear();
Write("Введите размер массива мин и макс через пробел:");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(parameters.Length);
int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);

WriteLine();
int negativeSum = 0;
int positiveSum = 0;

foreach (var a in array)
{
    negativeSum += a < 0 ? a : 0;
    positiveSum += a > 0 ? a : 0;
}

WriteLine($"{negativeSum}  {positiveSum}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}