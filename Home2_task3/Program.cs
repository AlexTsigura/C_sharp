Console.WriteLine("введите число");
int numberday = Convert.ToInt32(Console.ReadLine());

if (numberday < 8 && 0 < numberday)
{
    if (numberday == 6 | numberday == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Это не день недели");
}