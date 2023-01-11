using static System.Console;
Clear();

WriteLine("Координаты точки а.");
WriteLine("Введите x");
bool isParse1 = int.TryParse(ReadLine(),out int ax);
WriteLine("Введите y");
bool isParse2 = int.TryParse(ReadLine(),out int ay);
WriteLine("Координаты точки b.");
WriteLine("Введите x");
bool isParse3 = int.TryParse(ReadLine(),out int bx);
WriteLine("Введите y");
bool isParse4 = int.TryParse(ReadLine(),out int by);


WriteLine(!isParse1 || !isParse2 || !isParse3 || !isParse4?"Не все координаты заданы числами!":$"a({ax},{ay});b({bx},{by})");

// WriteLine($"Длина отрезка ab равна: {Math.Sqrt((ax-bx)*(ax-bx) + (ay-by)*(ay-by))}");Math.Sqrt - вычисление корня числа или выражения
// WriteLine($"Длина отрезка ab равна: {Math.Sqrt(Math.Pow((ax-bx),2) + Math.Pow((ay-by),2))}");Math.Pow возведение в указанную степень
// WriteLine($"Длина отрезка ab равна: {[Math.Sqrt(Math.Pow((ax-bx),2) + Math.Pow((ay-by),2))]:f2}");  :f2 сокращение ответа до 2 знаков,
// если заменить на p2 то дополнительно переведет в проценты
WriteLine($"Длина отрезка ab равна: {Math.Sqrt(Math.Pow((ax-bx),2) + Math.Pow((ay-by),2)):f2}");