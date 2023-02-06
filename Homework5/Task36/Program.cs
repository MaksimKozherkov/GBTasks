//Задача 36: Напишите программу реализующую методы формирования массива,
// заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.



using static System.Console;
Clear();

int[] array = GetArray(15);
Write($"Сумма элементов в массиве:");
printArray(array);
Write("находящихся на нечетных позициях равна:");
Para(array);
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

void Para(int[] array)  // метод подсчёта суммы элементов на нечётных позициях в массиве
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += (i % 2 == 1) ? array[i] : 0;
    }
    Write(sum);
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
