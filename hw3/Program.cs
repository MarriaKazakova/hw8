using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = {
            {2, 4, 2},
            {3, 2, 3},
            {4, 3, 4}
        };

        int[,] matrix2 = {
            {3, 4},
            {3, 3},
            {4, 4}
        };

        int row1 = matrix1.GetLength(0);
        int colum1 = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int colum2 = matrix2.GetLength(1);

        if (colum1 != row2)
        {
            Console.WriteLine("Умножение матриц невозможно!");
            return;
        }
        int[,] product = new int[row1, colum2];

        // Вычисление произведения матриц
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < colum2; j++)
            {
                int sum = 0;
                for (int k = 0; k < colum1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                product[i, j] = sum;
            }
        }
        Console.WriteLine("Матрица 1:");
        PrintMatrix(matrix1);
        Console.WriteLine("Матрица 2:");
        PrintMatrix(matrix2);
        Console.WriteLine("Произведение матриц:");
        PrintMatrix(product);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int colum = matrix.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < colum; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}