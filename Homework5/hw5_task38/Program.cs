// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArrayOfRandomNumbers(int numberOfElements)
{
    double[] array = new double[numberOfElements];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() , 2);
    }
    return array;
}

double DifOfMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    int size = array.Length;

    for (int i = 1; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }

    double result = max - min;
    return result;
}

int numberOfElements = 5;
double[] array = CreateArrayOfRandomNumbers(numberOfElements);

Console.WriteLine($"[{String.Join(" ; ", array)}]");
Console.WriteLine($"Max value - min value = {DifOfMaxMin(array)}");
