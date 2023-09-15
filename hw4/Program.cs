using System;

public class Answer {
    public static void PrintArray(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateSpiralArray(int size, int startNumber, int stepSize)
    {
        int[,] spiralArray = new int[size, size];
        int row1 = 0;
        int row2 = size - 1;
        int column1 = 0;
        int column2 = size - 1;
        int currentValue = startNumber;

        while (row1 <= row2 && column1 <= column2)
        {
            for (int i = column1; i <= column2; i++)
            {
                spiralArray[row1, i] = currentValue;
                currentValue += stepSize;
            }
            row1++;

            for (int i = row1; i <= row2; i++)
            {
                spiralArray[i, column2] = currentValue;
                currentValue += stepSize;
            }
            column2--;

            if (row1 <= row2)
            {
                for (int i = column2; i >= column1; i--)
                {
                    spiralArray[row2, i] = currentValue;
                    currentValue += stepSize;
                }
                row2--;
            }

            if (column1 <= column2)
            {
                for (int i = row2; i >= row1; i--)
                {
                    spiralArray[i, column1] = currentValue;
                    currentValue += stepSize;
                }
                column1++;
            }
        }

        return spiralArray;
    }

    static public void Main(string[] args)
    {
        int size = 4;
        int startNumber, stepSize;

        Console.WriteLine("Введите начальное число спирального массива:");
        startNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите размер шага:");
        stepSize = int.Parse(Console.ReadLine());

        int[,] spiralArray = CreateSpiralArray(size, startNumber, stepSize);
        PrintArray(spiralArray);
    }
}