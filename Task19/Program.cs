using static System.Console;
Clear();

WriteLine("Всего сделано деталей: ");
int a = int.Parse(ReadLine()!);
WriteLine(a%6==0?$"Каждый из мл.токарей сделал {a/6} деталей,а старший токарь сделал {a/3*2} деталей":$"Токарь ошибся");
