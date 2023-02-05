using static System.Console;

Clear();


Write("Введите начальное значение отрезка:");
int start = int.Parse(ReadLine()!);
Write("Введите конечное значение отрезка:");
int finish = int.Parse(ReadLine()!);

int[] array = GetArray(123);
int countInArray = findCountNumberInArray(array, start, finish);
Write("Коддшчество найденных элементов в массиве; ");
printArray(array);
WriteLine($" равно {countInArray}");


int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(0, 1000);
    }

    return resultArray;
}


int findCountNumberInArray(int[] array, int start, int finish)
{
    int result = 0;
    foreach (int i in array)
    {
        if (start <= i && i <= finish) result++;
    }
    return result;
}




void printArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    Write($"{array[array.Length - 1]}]");
}