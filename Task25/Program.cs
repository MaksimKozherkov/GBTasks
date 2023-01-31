using static System.Console;

Clear();

int[] array = InitBinaryArray();
PrintArray(array);


int[] InitBinaryArray()
{
    int[] res=new int[8];
    for (int i = 0; i < res.Length; i++)
    {
        Random  ran = new Random();
        res[i] = ran.Next(2);
    }
    return res;
}



void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Write($"{arr[i]} ");    
    }
    WriteLine();
}