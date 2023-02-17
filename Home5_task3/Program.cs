int inputInt(string massage)
{
    Console.WriteLine(massage);
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void CreateArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) /100;
    }
}

void PrintArray(double[]array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i != array.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}

void Calculations(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
        if (array[j] < min)
        {
            min = array[j];
        }
    }
    Console.Write($"максимальный = {max}");
    Console.Write($"Минимальный = {min}");
    Console.Write($"Разница = {max - min}");
}

int size = inputInt("Введите колличество элементов");
double[] array = new double[size];
CreateArray(array);
Console.Write("Массив");
PrintArray(array);
Calculations(array);