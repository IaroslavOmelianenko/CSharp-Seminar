// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] CreateArrayOfRandomNumbers(int numberOfElements)
{
    int[] array = new int[numberOfElements];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[]  MultiplyCoupleNumbers(int[] array)
{
    int size = array.Length;
    int[] result = new int[size/2+1];
    int resultArraySize = result.Length;

    for (int i = 0; i < resultArraySize; i++)
    {
        if (i == resultArraySize - 1) result[i] = array[i];
        else result[i] = array[i] * array[size-1-i];
    }
    return result;
}

int numberOfElements = 5;
int[] array = CreateArrayOfRandomNumbers(numberOfElements);

Console.WriteLine($"[{String.Join(" ; ", array)}]");
Console.WriteLine($"Multipication of coupled numbers: {String.Join(" ; ", MultiplyCoupleNumbers(array))}");
