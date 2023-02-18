int[] CreatArray(string massage)
{
    Console.WriteLine(massage);
    int sizeMas = Convert.ToInt32(Console.ReadLine());
    int[] mas = new int[sizeMas];
    return mas;
}

int[] FilArray(int[] baseArray, string massage)
{
    for (int i = 0; i < baseArray.Length; i++)
    {
        Console.WriteLine(massage);
        baseArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return baseArray;
}

void DisplayElements(int[] baseArray)
{
    Console.WriteLine("Введёные числа");
    for (int i = 0; i < baseArray.Length; i++)
    {
        Console.WriteLine($"{baseArray[i]}");
    }
}

void FindNum(int[] baseArray)
{
    int count = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i] > 0)
        {
            count++;
        }
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Колличество чисел со значением больше нуля{count}");
    Console.ResetColor();
}

int[] baseArray = CreatArray("Введите колличество чисел");
string massage = $"Введите число";
FilArray(baseArray, massage);
DisplayElements(baseArray);
FindNum(baseArray);