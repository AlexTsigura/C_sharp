
const int K1 = 0;
const int B1 = 1;
const int K2 = 2;
const int B2 = 3;

void UserInpunt(double[] coeff, string massage)
{
    Console.WriteLine($"Введите коэфициенты");
    for (int i = 0; i <= coeff.Length - 1; i++)
    {
        coeff[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double FindX (double[] coeff)
{
    double x = (coeff[B2]-coeff[B1])/(coeff[K1]-coeff[K2]);
    return x;
}

double FindY(double[] coeff)
{
    double x = FindX(coeff);
    double y = coeff[K1]*x + coeff[B1];
    return y;
}

double[] coeff = new double[4];

UserInpunt(coeff, "Введите коэфициенты для рассчета");
double resultX = FindX(coeff);
double resultY = FindY(coeff);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Координаты пересечения двух прямых {resultX}, {resultY}");
Console.ResetColor();