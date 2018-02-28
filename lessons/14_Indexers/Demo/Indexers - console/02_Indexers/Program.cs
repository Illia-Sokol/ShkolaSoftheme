using System;

namespace _02_Indexers
{
    class Program
    {
        static void Main()
        {
            var matrix = new Matrix(3);

            ShowMatrixInfo(matrix);

            matrix[1, 1] = 111;

            ShowMatrixInfo(matrix);
        }

        private static void ShowMatrixInfo(Matrix matrix)
        {
            Console.WriteLine();
            for (int i = 0; i <= matrix.Size; i++)
            {
                for (int j = 0; j <= matrix.Size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
