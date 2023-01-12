using static System.Console;
Clear();

WriteLine("Координаты точки A.");
WriteLine("Введите x:");
bool isParse1 = int.TryParse(ReadLine(),out int ax);
WriteLine("Введите у:");
bool isParse2 = int.TryParse(ReadLine(),out int ay);
WriteLine("Введите z:");
bool isParse3 = int.TryParse(ReadLine(),out int az);
WriteLine("Координаты точки B.");
WriteLine("Введите x:");
bool isParse4 = int.TryParse(ReadLine(),out int bx);
WriteLine("Введите y:");
bool isParse5 = int.TryParse(ReadLine(),out int by);
WriteLine("Введите z:");
bool isParse6 = int.TryParse(ReadLine(),out int bz);

if(!isParse1 || !isParse2 || !isParse3 || !isParse4 || !isParse5 || !isParse6)

{WriteLine("Не все координаты заданы числами!"); return;}

WriteLine($"A({ax},{ay},{az}); B({bx},{by},{bz})");

WriteLine($"Расстояние между точками A и B равно: {Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)):f2}");