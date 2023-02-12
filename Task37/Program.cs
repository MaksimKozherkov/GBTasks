using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));
PrintMatrixArray(array);
WriteLine();
int[,] matrix=newMatrix(array);
PrintMatrixArray(matrix);

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


int[,] newMatrix(int[,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(i%2==0&&j%2==0&&i>0&&j>0)
            {
                inArray[i,j]=inArray[i,j]*inArray[i,j];
            }
        }
    }
    return inArray;
}