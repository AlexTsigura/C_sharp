//Задача 2
Console.WriteLine("введите первое число");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int secondnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int thirdnumber = Convert.ToInt32(Console.ReadLine());

int max = firstnumber;
if (secondnumber > max) max = secondnumber;
if (thirdnumber > max) max = thirdnumber;


Console.WriteLine("максимальное число =");
Console.WriteLine(max);