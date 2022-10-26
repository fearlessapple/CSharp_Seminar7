Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
AriphmethicSum(array, rows);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void AriphmethicSum(int[,] array, int rows)
{
    int resultSum = 0;
    int sum = 0;
    double result = 0;
    for (int j = 0; j < rows + 1; j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            resultSum = array[i, j] + sum;
            sum = resultSum;
        }
        result = (double)sum / (double)rows;
        Console.WriteLine($"Арифмитическая сумма столбца: {result}");
        sum = 0;
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
