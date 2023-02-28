//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArrayOfRandomNumbers(int numberOfElements)
{
    int[] array = new int[numberOfElements];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int CountEvenNumbers(int[] array)
{
    int counter = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
}

int numberOfElements = 4;
int[] array = CreateArrayOfRandomNumbers(numberOfElements);

Console.WriteLine($"[{String.Join(" , ", array)}]");
Console.WriteLine($"Amount of even numbers: {CountEvenNumbers(array)}");