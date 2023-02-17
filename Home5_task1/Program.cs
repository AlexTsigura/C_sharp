int inputInt(string massage)
{
    Console.WriteLine(massage);
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void CreateArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

int CountArray(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j]%2==0)
        {
            count++;
        }
        
    }
    Console.WriteLine($"Четные{count}");
    return count;
}

int size = inputInt("Введите колличество элементов");
int[] array = new int[size];
CreateArray(array);
Console.Write("Массив");
PrintArray(array);
int result = CountArray(array);