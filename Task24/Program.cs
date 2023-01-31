using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);




WriteLine($"Колличество цифр в числе {number} равна {NumProduct(number)}");






int NumProduct(int num)
{
    int result = 0;
    while(num>0)
    {
        result++;
        num/=10;
    }

    return result;
}