// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
/// Method requesting from console size for two matricies and multiplicating this matricies, if its aviable.
/// </summary>
/// <returns>Matrix with multiplication result</returns>
int[,] MultiplicationOfTwoMatrices()
{
    Console.WriteLine("Enter parameters of Matrix 1");
    int[,] matrix1 = MatrixRequest();
    Console.WriteLine("Enter parameters of Matrix 2");
    int[,] matrix2 = MatrixRequest();

    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Matrices cant be multiplied. Matrix1 columns quantity not equal Matrix2 rows quantity");
        Console.WriteLine("Try again");
        MultiplicationOfTwoMatrices();
    }
    else
    {
        Console.WriteLine("MATRIX 1:");
        PrintMatrix(matrix1);
        Console.WriteLine();
        Console.WriteLine("MATRIX 2:");
        PrintMatrix(matrix2);

        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = matrix1[i, 0] * matrix2[0, j] + matrix1[i, 1] * matrix2[1, j];
            }
        }
    }
    return resultMatrix;
}

int[,] resultMatrix = MultiplicationOfTwoMatrices();
Console.WriteLine();
Console.WriteLine("Result Matrix:");
PrintMatrix(resultMatrix);