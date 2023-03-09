// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
    Console.WriteLine("Your matrix:");
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

void PrintAvarageValueOfColumnsElements(int[,] matrix)
{
    int rowsQuantity = matrix.GetLength(0);
    int columnsQuantity = matrix.GetLength(1);

    double[] result = new double[columnsQuantity];

    double counter = 0;
    for (int i = 0; i < columnsQuantity; i++)
    {
        counter = 0;
        for (int j = 0; j < rowsQuantity; j++)
        {
            counter += matrix[j, i];
        }
        result[i] = Math.Round((counter / rowsQuantity), 2);
    }
    Console.WriteLine($"Avarage vaule of columns elements: [{String.Join(" , ", result)}]");
}


int min = 0;
int max = 10;
int inputRows = ValueRequest("number of rows");
int inputColumns = ValueRequest("number of columns");

int[,] resultMatrix = GetMatrix(inputRows, inputColumns, min, max);
PrintMatrix(resultMatrix);
PrintAvarageValueOfColumnsElements(resultMatrix);

