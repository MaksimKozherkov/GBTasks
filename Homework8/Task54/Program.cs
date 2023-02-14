using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);

WriteLine();
srArr(array);
PrintMatrixArray(array);
int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
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
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}

void srArr(int[,] srArray)
{
    for (int c = 0; c <= (srArray.GetLength(0)*srArray.GetLength(1)); c++)
    {    
        for (int i = 0; i < srArray.GetLength(0); i++)
        {
            for (int j = 0; j < srArray.GetLength(1)-1; j++)
            {
                if (srArray[i, j] < srArray[i, j + 1])
                {
                    int tmp = srArray[i, j];
                    srArray[i, j] = srArray[i, j + 1];
                    srArray[i, j + 1] = tmp;
                }
            }
        }
    }
}