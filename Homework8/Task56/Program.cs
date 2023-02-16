using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));
PrintMatrixArray(array);
WriteLine();
SumMinRow(array);
int[,] GetMatrixArray(int rows,int colums, int minValue, int maxValue)
{
    Random rnd=new Random();
    int[,] resultArray=new int[rows,colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i,j]=rnd.Next(minValue,maxValue+1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],5} ");
        }
        WriteLine();
    }
}


void SumMinRow(int[,] matrixArray)      
{
    int[] resultArr = new int[matrixArray.GetLength(0)];
    for (int i = 0; i < matrixArray.GetLength(0); i++)      
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            int a = i;
            resultArr[a] += matrixArray[i, j];
            if (j == matrixArray.GetLength(1) - 1)
            {
                WriteLine($"Сумма элементов строки {a + 1} равна -> {resultArr[a]}");
            }
        }

    int min = int.MaxValue;
    string SumMin = string.Empty;
    for (int i = 0; i < resultArr.Length; i++)      
    {
        if (resultArr[i] < min)
        {
            min = resultArr[i];
            SumMin = $"{i + 1} строка";
        }
    }
    WriteLine();
    WriteLine($"{SumMin} cтрока с наименьшей суммой элементов.");
    WriteLine();
}