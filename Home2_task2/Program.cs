Console.WriteLine("введите число");
int firstnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber < 99)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (firstnumber > 1000)
    {
        firstnumber = firstnumber / 10;
    }
}
firstnumber = firstnumber % 10;
Console.WriteLine($"Третье число {firstnumber}");