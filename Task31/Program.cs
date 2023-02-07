using static System.Console;

Clear();
Write("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

WriteLine($"[{string.Join(",", array)}]");//string.Join соединяет выводимые значения ("разделитель данных,от куда беруться данные")(работает ток в одномерном массиве)
ReverseArray2(array);
WriteLine($"[{string.Join(",", array)}]");
//WriteLine($"[{string.Join(",",ReverseArray1(array))}]");

int[] GetArray(int size)//метод создания массива
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1, 10);
    }
    return resultArray;
}

int[] ReverseArray1(int[] inArray)//метод переворота массива
{
    int[] result=new int[inArray.Length];
    for (int i=0;i<inArray.Length;i++)
    {
        result[i]=inArray[inArray.Length-1-i];
    }
    return result;
}

void ReverseArray2(int[] inArray)//2 метод переворота массива
{
    for (int i=0;i<inArray.Length/2;i++)
    {
        int temp=inArray[i];
        inArray[i]=inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i]=temp;
    }
}