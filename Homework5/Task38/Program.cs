using static System.Console;

Clear();

double[] array = GetArray(15,1,100);

Write("Полученный массив: ");
printArray(array);
SumDifferenceMinAndMax(array);






double[] GetArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

void printArray(double[] array)  
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]:f2}, ");
    }
    WriteLine($"{array[array.Length - 1]:f2}]");
}

void SumDifferenceMinAndMax(double[] array)     
{
    double min = array[0];
    double max = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double result = max - min;
    Write($"Разница между {max:f2} и {min:f2} равна: {result:f2}");
}

