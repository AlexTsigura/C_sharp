int PointCordinate(string cor, string point)
{
    Console.WriteLine($"Введите координату {cor} точки {point}");
    return Convert.ToInt32(Console.ReadLine());
}

int X1 = PointCordinate("X", "A");
int Y1 = PointCordinate("Y", "A");
int Z1 = PointCordinate("Z", "A");
int X2 = PointCordinate("X", "B");
int Y2 = PointCordinate("Y", "B");
int Z2 = PointCordinate("Z", "B");

double decision(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double segment1 = Math.Pow(X2-X1, 2);
    double segment2 = Math.Pow(Z2-Z1, 2);
    double segment3 = Math.Pow(Z2-Z1, 2);
    double res = Math.Sqrt(segment1 + segment2 + segment3);
    return res;
}

double length = decision(X1, X2, Y1, Y2, Z1, Z2);

Console.WriteLine($"Длина отрезка{length:F3}");