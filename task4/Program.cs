Console.WriteLine("введите число");
int firstnumber = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (firstnumber > count)
{
    Console.WriteLine(count);
    count = 2 + 2;
    if (firstnumber < count)
    {
        Console.WriteLine("конец");
    }
}