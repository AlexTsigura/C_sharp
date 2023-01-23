Console.WriteLine("введите число");
int firstnumber = Convert.ToInt32(Console.ReadLine());

bool validate (int firstnumber)
{
    if (firstnumber < 1000 && 99 < firstnumber)
    {
        return true;
    }
    Console.WriteLine("Ошибка");
    return false;
}

if (validate(firstnumber))
{
    firstnumber = firstnumber / 10;
    firstnumber = firstnumber % 10;
    Console.WriteLine($"Вторая цифра {firstnumber}");
}