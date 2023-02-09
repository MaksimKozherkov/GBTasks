using static System.Console;

Clear();


int arraysize = AskUser("Введите количество элементов массива: ");


int[] resultArray = new int[arraysize];

for (int i = 0; i < arraysize; i++)
{
    Write($"Введите элемент массива по индексом {i}: ");
    resultArray[i]=int.Parse(ReadLine()!);
}
int[] array = resultArray;
WriteLine($"Количество введенных чисел больше 0 (нуля) равно: {PositiveNum(array)}");



// WriteLine($"[{string.Join(",", array)}]");





int PositiveNum(int[] array)
 {
    int result = 0;
    foreach (int a in array)
    {
        if (a>0) result++;
    }
    return result;
}






int AskUser(string inAsk)
{
    int resultAsk = 0;
    string userAsk = "";
    while (!int.TryParse(userAsk, out resultAsk))
    {
        Console.Write(inAsk);
        userAsk = Console.ReadLine()!;
    }
    return resultAsk;
}

