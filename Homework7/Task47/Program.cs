using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");

double[] intParams=Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries),double.Parse);

double[,] array=GetMatrixArray(intParams[0],intParams[1],intParams[2],intParams[3]);

PrintMatrixArray(array);

double[,] GetMatrixArray(double rows,double colums, double minValue, double maxValue)
{
    double[,] resultArray=new double[(int)rows,(int)colums];
    Random rnd=new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return resultArray;
}




void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],8:F2} ");
        }
        WriteLine();
    }
}
