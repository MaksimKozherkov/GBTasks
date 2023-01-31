using static System.Console;
Clear();

WriteLine("Введите число: ");
bool numb = int.TryParse(ReadLine(),out int number);




WriteLine($"Сумма цифр в числе {number} равна {NumSumm(number)}");






int NumSumm(int num)
{
    int result = 0;
    int a=0;
    while(num>0)
    {
        a=num%10;
        num/=10;
        result+=a;
    }

    return result;
}