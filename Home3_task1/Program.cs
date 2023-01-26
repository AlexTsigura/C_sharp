int Input(string massage)
{
    Console.WriteLine(massage);
    string? number = Console.ReadLine();
    int result = Convert.ToInt32(number);
    return result;
}

int number = Input("Введите целое натуральное число");
Console.WriteLine(Palidrom(number));

int Palidrom(int number)
{
    int temp = 0;
    int var = 0;
    int index = 0;
    temp = var;
    while (temp > 0)
    {
        index = index * 10;
        index = index + temp % 10;
        temp = temp / 10;   
    }
    if (var == index)
    {
        Console.WriteLine("Число полидром");
    }
    else
    {
        Console.WriteLine("Число не полидром");
    }
    return number;
}
