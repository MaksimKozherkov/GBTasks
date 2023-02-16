using static System.Console;

Clear();

WriteLine("Для создания матрицы, введите значения, где:");
WriteLine("    1) кол-во строк;");
WriteLine("    2) кол-во столбцов;");
WriteLine("    3) min-ый диапазон случайного значения;");
WriteLine("    4) max-ый диапазон случайного значения;");
WriteLine();
Write("Введите значения через пробел, для формирования первой матрицы: ");
string[] inputParamOne = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
int[,] matrixOne = GetMatrixArray(int.Parse(inputParamOne[0]), int.Parse(inputParamOne[1]), Convert.ToInt32(inputParamOne[2]), Convert.ToInt32(inputParamOne[3]));
WriteLine();
Write("Введите значения через пробел, для формирования второй матрицы: ");
string[] inputParamTwo = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
int[,] matrixTwo = GetMatrixArray(int.Parse(inputParamTwo[0]), int.Parse(inputParamTwo[1]), Convert.ToInt32(inputParamTwo[2]), Convert.ToInt32(inputParamTwo[3]));

WriteLine();
WriteLine("Полученная первая матрица: ");
PrintMatrixArray(matrixOne);
WriteLine();
WriteLine("Полученная вторая матрица: ");
PrintMatrixArray(matrixTwo);
WriteLine();
MatrixMultiplication(matrixOne, matrixTwo);
WriteLine();




int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)    // метод формирования матрицы
{
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] matrixArray)       // метод вывода заполненной матрицы
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Write($"{matrixArray[i, j],6}");
        }
        WriteLine();
    }
}

void MatrixMultiplication(int[,] arrayOne, int[,] arrayTwo)     // метод умножения матрицы на матрицу
{
    if (arrayOne.GetLength(1) != arrayTwo.GetLength(0))
    {
        WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    else
    {
        int[,] result = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
        for (int i = 0; i < arrayOne.GetLength(0); i++)
        {
            for (int j = 0; j < arrayTwo.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int a = 0; a < arrayOne.GetLength(1); a++)
                {
                    result[i, j] += arrayOne[i, a] * arrayTwo[a, j];
                }
            }
        }
        PrintMatrixArray(result);
    }
}