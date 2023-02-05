using static System.Console;

Clear();


int[] array = { -1, -2, 0, 2, 1, 3, 4 };


InverseArray(array);
PrintArray(array);





void InverseArray(int[] InArray)
{
    for (int i = 0; i < InArray.Length; i++)
    {
        InArray[i] *= -1;
    }
}

void PrintArray(int[] InArray)
{
    Write("[");
    for (int i = 0; i < InArray.Length - 1; i++)
    {
        Write($"{InArray[i]},");
    }
    WriteLine($"{InArray[InArray.Length - 1]}]");
}


