// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] CreateArrayOfRandomNumbers(int numberOfElements)
{
    int[] array = new int[numberOfElements];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

int SumOfOddPositionNumbers(int[] array)
{
    int sum = 0;
    int size = array.Length;
    for (int i = 1; i < size; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int numberOfElements = 4;
int[] array = CreateArrayOfRandomNumbers(numberOfElements);

Console.WriteLine($"[{String.Join(" , ", array)}]");
Console.WriteLine($"Sum of odd-position numbers: {SumOfOddPositionNumbers(array)}");