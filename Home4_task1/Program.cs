int value(string massage)
{
    Console.WriteLine(massage);
    string number = Console.ReadLine();
    return Convert.ToInt32(number);
}

long Pow(int a, int b)
{
    int temp = 1;
    long res = 1;
    while (temp <= Math.Abs(b))
    {
        res *=a;
        temp++;
    }
    return res;
}

int a = value("Введите число");
int b = value("Введите степень");

if (b >= 0)
{
    long res = Pow(a, b);
    Console.WriteLine($"{a} в степени {b} равно {res}");
}
else
{
    Console.WriteLine($"Степень отрицательна");
}
