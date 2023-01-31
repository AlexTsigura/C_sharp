int value(string massage)
{
    Console.WriteLine(massage);
    string number = Console.ReadLine();
    return Convert.ToInt32(number);
}

int summa(int number)
{
    int sum = 0;
    while (number !=0)
    {
        int digit = number % 10;
        sum += digit;
        number /=10;
    }
    return sum;
}

int number = value("Введите число");
int result = summa(number);
Console.WriteLine($"Сумма цифр числа равна {result}");