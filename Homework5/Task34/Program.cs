
using static System.Console;

Clear();





int[] array = GetArray(10);

int countInArray = EvenNumberInArray(array);
printArray(array);

Write($"Количество четных элементов в массиве: равно {countInArray}");



int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(99, 1000);
    }

    return resultArray;
}

int EvenNumberInArray(int[] array)
{
    int result = 0;
    foreach (int i in array)
    {
        if (i%2==0) result++;
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

    WriteLine($"{array[array.Length - 1]}]");
}








