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

int sumIndex(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j = j +2)
    {
        sum = sum + array[j];
    }
    Console.Write($"Сумма = {sum}");
    return sum;
}

int size = inputInt("Введите колличество элементов");
int[] array = new int[size];
CreateArray(array);
Console.Write("Массив");
PrintArray(array);
int result = sumIndex(array);