using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] intParams=Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries),int.Parse);
int[,] array=GetMatrixArray(intParams[0],intParams[1],intParams[2],intParams[3]);

Write("Введите номер строки и столбца искомого числа через пробел: ");
string[] pos = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
string posInArray = ElementPos(int.Parse(pos[0]), int.Parse(pos[1]), array);



WriteLine("Полученная таблица: ");
PrintMatrixArray(array);
WriteLine(posInArray);

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


string ElementPos(int rowsPos, int columnsPos, int[,] matrixArray)    // метод поиска искомого элемента по позиции в таблице
{
    string resultPosition = string.Empty;
    if (rowsPos <= matrixArray.GetLength(0) && columnsPos <= matrixArray.GetLength(1))
    {
        if (rowsPos > 0 && columnsPos > 0)
        {
            resultPosition = $"Искомый элемент в таблице равен -> " + matrixArray[rowsPos - 1, columnsPos - 1];
        }
        else { resultPosition = "Такого элемента в таблице нет!"; }
    }
    else { resultPosition = "Такого элемента в таблице нет!"; }
    return resultPosition;
}