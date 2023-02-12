using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));
PrintMatrixArray(array);
WriteLine();
int result=newMatrix(array);
WriteLine($"{result}");

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


int newMatrix(int[,] inArray)
{
    int sum=0;
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(i==j)
            {
                sum+=inArray[i,j];
            }
        }
    }
    return sum;
}