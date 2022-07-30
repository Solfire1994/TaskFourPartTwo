using System;

namespace TaskFourPartOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];
            int[,] matrix2 = new int[row, col];
            int[,] sumMatrix = new int[row, col];
            Random random = new Random();
            Console.WriteLine("Первая матрица");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                    matrix2[i, j] = random.Next(-10, 10);
                    sumMatrix[i, j] = matrix[i, j] + matrix2[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Вторая матрица");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Сумируюцая матрица");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{sumMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
