using static System.Console;

Clear();
//y = k1 * x + b1, y = k2 * x + b2

Write("Введите b1:");
int b1 = int.Parse(ReadLine()!);
Write("Введите b2:");
int b2 = int.Parse(ReadLine()!);
Write("Введите k1:");
int k1 = int.Parse(ReadLine()!);
Write("Введите k2:");
int k2 = int.Parse(ReadLine()!);
double x = MetodsLineX(b1,b2,k1,k2);
double y = MetodsLineY(b1,b2,k1,k2,x);
WriteLine($"Координаты точки пересечения 2 прямых ({MetodsLineX(b1,b2,k1,k2)},{MetodsLineY(b1,b2,k1,k2,x)})");




double MetodsLineX(double B1, double B2, double K1, double K2)
{
    double x1 = (B1 - B2) / (K2 - K1);
    return x1;
}

double MetodsLineY(double B1, double B2, double K1, double K2,double X)
{
    
    double y2 = K2 * X + B2;
    return y2;
    
}