using static System.Console;
Clear();

WriteLine("Введите пятизначное число:");
bool isParse = int.TryParse(ReadLine(),out int i);
if(!isParse)
{
    WriteLine("Введенные данные не являются числом");
    return;
}
// WriteLine($"{i%100/10}");
 WriteLine(i<10000 || i>99999?
"Введено не пятизначное число!":
i/10000==i%10 || i/1000%10==i%100/10?$"Число {i} является палиндромом.":$"Число {i} не является палиндромом.");