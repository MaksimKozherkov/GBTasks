using static System.Console;
Clear();

int[] array = GetArray(5);
printArray(array);
int[] array2 = multiPara(array);
printArray(array2);

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(0, 10);
    }

    return resultArray;
}

int[] multiPara(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }

    return result;
}


void printArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]},");
    }
    WriteLine($"{array[array.Length - 1]}]");
}
