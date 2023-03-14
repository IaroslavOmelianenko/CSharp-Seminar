//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int ValueRequest(string requestDescription)
{
    Console.WriteLine($"Enter {requestDescription} :");
    int value = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    return value;
}

int[,] MatrixRequest()
{
    int minValue = 0;
    int maxValue = 10;
    int inputRows = ValueRequest("number of rows");
    int inputColumns = ValueRequest("number of columns");
    int[,] resultMatrix = GetMatrix(inputRows, inputColumns, minValue, maxValue);
    return resultMatrix;
}

/// <summary>
/// Sorting matrix rows. Each row of matrix sorting as array using bubble sort.
/// </summary>
/// <param name="matrix"></param>
/// <returns>Sorted matrix</returns>
int[,] SortMatrixRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int temp = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < cols - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }

    return matrix;
}

int[,] matrixForSort = MatrixRequest();
Console.WriteLine("Your matrix:");
PrintMatrix(matrixForSort);

int[,] sortedMatrix = SortMatrixRows(matrixForSort);
Console.WriteLine("SortedMatrix:");
PrintMatrix(sortedMatrix);