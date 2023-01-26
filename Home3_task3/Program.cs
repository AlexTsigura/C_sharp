int Input(string massage)
{
    Console.WriteLine(massage);
    string? inputvalue = Console.ReadLine();
    int result = Convert.ToInt32(inputvalue);
    return result;
}

int number = Input("Введите число");
Console.WriteLine($"Кубы от 1 до {number}");

for (int var = 0; var <= number; var++)
{
    int result = var * var * var;
    Console.WriteLine(result);
}