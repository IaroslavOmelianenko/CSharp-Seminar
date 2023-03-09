// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetMatrix(int rows, int cols, double minValue, double maxValue)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    Console.WriteLine("Your matrix:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j].ToString("N2")}\t");
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

double min = 0;
double max = 10;
int m = ValueRequest("number of rows");
int n = ValueRequest("number of columns");

PrintMatrix(GetMatrix(m, n, min, max));
