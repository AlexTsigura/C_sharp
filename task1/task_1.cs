//Задача 1
Console.WriteLine("введите первое число");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int secondnumber = Convert.ToInt32(Console.ReadLine());
if (firstnumber > secondnumber)
{
    Console.WriteLine($"Наибольшее число {firstnumber} , наименьшее число {secondnumber}");
}
else
{
    Console.WriteLine($"Наибольшее число {secondnumber} , наименьшее число {firstnumber}");
}
