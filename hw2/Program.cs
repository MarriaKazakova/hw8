using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 1, 2, 1, 1 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        Console.WriteLine("Исходный массив:");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        int minRowIndex = 0;
        int minRowSum = int.MaxValue;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRowIndex = i;
            }
        }

        Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minRowIndex + 1));

        Console.ReadLine();
    }
}
