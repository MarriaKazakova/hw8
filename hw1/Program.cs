using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        SortRowsDescending(array);

        Console.WriteLine("Упорядоченный массив:");
        PrintArray(array);
    }
    static void PrintArray(int[,] array)
    {
        int row = array.GetLength(0);
        int colum = array.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < colum; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void SortRowsDescending(int[,] array)
    {
        int row = array.GetLength(0);
        int colum = array.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            int[] tempArray = new int[colum];
            for (int j = 0; j < colum; j++)
            {
                tempArray[j] = array[i, j];
            }
            Array.Sort(tempArray);
            Array.Reverse(tempArray);
            for (int j = 0; j < colum; j++)
            {
                array[i, j] = tempArray[j];
            }
        }
    }
}
