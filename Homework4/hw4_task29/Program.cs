// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] NumbersForArrayRequest()
{
    Console.WriteLine("Enter number of elements:");
    int numberOfElements = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[numberOfElements];
    Console.WriteLine($"Enter {numberOfElements} numbers for array:");
    for (int i = 0; i < numberOfElements; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] CreateArrayOfRandomNumbers(int numberOfElements)
{
    int[] array = new int[numberOfElements];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join( " , ", array)}]");
}

PrintArray(NumbersForArrayRequest());