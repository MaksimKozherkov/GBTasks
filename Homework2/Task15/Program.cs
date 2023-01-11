using static System.Console;
Clear();
WriteLine("Введите номер дня недели: ");
int day = int.Parse(ReadLine()!);

WriteLine((day<=7 && day>=6)?"Это выходной!":(day <= 7 && day >= 1)?"Это рабочий день!":"В неделе всего 7 дней!");