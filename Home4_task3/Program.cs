int value(string massage)
{
    Console.WriteLine(massage);
    string number = Console.ReadLine();
    return Convert.ToInt32(number);
}

int length = value("Введите колличество элементов");
int min = value("Введите минимельное число в массиве");
int max = value("Введите максимальное число в массиве");

bool checknumber(int min, int length, int max)
{
    if (max <= min || length == 0)
    {
        Console.WriteLine("Максимальное должно быть больше минимального");
        return false;
    }
    return true;
}

int[] Set(int length)
{
    int[] temparr = new int[length];
    for (int i = 0; i < length; i++)
        temparr[i] = new Random().Next(min, max);
    
    return temparr;
}

void writeconsle(int[] intarray)
{
    for (int i = 0; i < intarray.Length; i++)
    {
        Console.WriteLine(intarray[i]);
        if (i != intarray.Length-1)
            Console.Write(", ");
    }
}

if (checknumber(min, max, length))
{
    Console.Write("Массив: ");
    writeconsle(Set(length));
}