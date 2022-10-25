Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите адрес искомого элемента массива: ");
int findRow = int.Parse(Console.ReadLine() ?? "");
int findColumn = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FindInArray(array, findRow, findColumn);

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

void FindInArray(int[,] array, int findRow, int findColumn)
{
   if (findRow<array.GetLength(0) || findColumn<array.GetLength(1))
   {
        Console.WriteLine($"Искомый элемент массива: {array[findRow, findColumn]}");
   }
   else
   {
    Console.WriteLine("Такого числа нет в массиве.");
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
