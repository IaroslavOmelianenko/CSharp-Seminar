// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] GetMatrix(int rows, int cols, int depth, int minValue, int maxValue)
{
    int[,,] matrix = new int[rows, cols, depth];
    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < cols; k++)
            {
                int randomNumber = new Random().Next(minValue, maxValue);
                while (!SearchDuplicateNumber(matrix, randomNumber))
                {
                    randomNumber = new Random().Next(minValue, maxValue);
                }
                matrix[j, k, i] = randomNumber;
            }
        }
    }
    return matrix;
}

bool SearchDuplicateNumber(int[,,] matrix, int number)
{
    bool numberIsUnique = true;

    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int depth = matrix.GetLength(2);

    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < cols; k++)
            {
                if (matrix[j, k, i] == number) numberIsUnique = false;
            }
        }
    }
    return numberIsUnique;
}

void PrintMatrixWithIndices(int[,,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int depth = matrix.GetLength(2);

    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < cols; k++)
            {
                Console.Write($"{matrix[j, k, i]} ({j},{k},{i})\t");
                if (k == depth - 1) Console.WriteLine();
            }
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

int[,,] MatrixRequest()
{
    int minValue = 10;
    int maxValue = 100;
    int inputRows = ValueRequest("number of rows");
    int inputColumns = ValueRequest("number of columns");
    int inputDepth = ValueRequest("depth value");
    int[,,] resultMatrix = GetMatrix(inputRows, inputColumns, inputDepth, minValue, maxValue);
    return resultMatrix;
}

int[,,] yourMatrix = MatrixRequest();
Console.WriteLine("Your matrix:");
PrintMatrixWithIndices(yourMatrix);

