using static System.Console;
Clear();

WriteLine("Введите первое число: ");
bool numb1 = int.TryParse(ReadLine(),out int number1);
WriteLine("Введите второе число: ");
bool numb2 = int.TryParse(ReadLine(),out int number2);




WriteLine($"{NamProduct(number1,number2)}");






int NamProduct(int num1, int num2)
{
    int i = 1;
    int num3=num1;
    while(i<num2)
    {
        num1*=num3;
        i++;
    }

    return num1;
}