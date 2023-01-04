using static System.Console;

WriteLine("Введите номер дня недели: ");
int day = int.Parse(ReadLine()!);

if (day <= 7 && day >= 1)
{
    if (day == 1)
    {
        Write("Понедельник");
    }
    if (day == 2)
    {
        Write("Вторник");
    }
    if (day == 3)
    {
        Write("Среда");
    }
    if (day == 4)
    {
        Write("Четверг");
    }
    if (day == 5)
    {
        Write("Пятница");
    }
    if (day == 6)
    {
        Write("Суббота");
    }
    if (day == 7)
    {
        Write("Воскресенье");
    }

}
else
{
     Write("В неделе всего 7 дней");
}