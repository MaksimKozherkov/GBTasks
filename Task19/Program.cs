using static System.Console;
Clear();

WriteLine("Всего сделано деталей: ");
int a = int.Parse(ReadLine()!);
WriteLine(a%4==0?$"Каждый из мл.токарей сделал {a/4} деталей,а старший токарь сделал {a/2} деталей":$"Токарь ошибся");
