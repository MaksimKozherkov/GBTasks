using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");

int[] intParams=Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries),int.Parse);

int[,] array=GetMatrixArray(intParams[0],intParams[1],intParams[2],intParams[3]);

PrintMatrixArray(array);
WriteLine();
srArr(array);
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
            Write($"{inArray[i,j],8} ");
        }
        WriteLine();
    }
}

void srArr(int[,] srArray)        
{
    double[] result = new double[srArray.GetLength(1)];
    for (int j = 0; j < srArray.GetLength(1); j++)
    {
        for (int i = 0; i < srArray.GetLength(0); i++)
        {
            result[j] += srArray[i, j];
        }
        Write($"{result[j] /= srArray.GetLength(0),9:f2}");
    }
}