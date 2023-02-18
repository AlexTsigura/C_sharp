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

double[] FindAVG(int[,] array)
{
    double[] avg = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            avg[j] += array[i, j];
        }
    }
    for (int i = 0; i < avg.Length; i++)
    {
        avg[i] /= array.GetLength(0);
    }
    return avg;
}

void PrintAvg(double[] array)
{
   Console.WriteLine("Среднее арифметическое столбцов:");
   for (int i = 0; i < array.Length; i++)
   {
    if (i < array.Length -1)
    {
        Console.Write($"{array[i]:F2}");
    }
    else
    {
        Console.Write($"{array[i]:F2}");
    }
   }
}

int[, ] resultArray = createArray();
PrintArray(resultArray);
double[] resultAVG = FindAVG(resultArray);
PrintAvg(resultAVG);


