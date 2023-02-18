int[,] createArray(int m =3, int n =4)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");

        }
        Console.WriteLine();
    }
}

int InputInt(string msg)
{
    Console.Write(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] resultArray = createArray();
PrintArray(resultArray);
int m = InputInt("Введите номер строки");
int n = InputInt("Введите номер столбца");
if (n < 1 || m < 1 || m > resultArray.GetLength(0) || n > resultArray.GetLength(1))
{
    Console.WriteLine("такого элемента нет!");
}
else
{
    Console.WriteLine($"Значение элемента {resultArray[m - 1, n -1]}");
}