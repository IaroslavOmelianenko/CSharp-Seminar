// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int NumbersQuantityRequest()
{
    Console.WriteLine("Enter numbers quantity: ");
    int numbersQuantity = Convert.ToInt32(Console.ReadLine());
    return numbersQuantity;
}

int[] InputRequest(int numbersQuantity)
{
    int[] array = new int[numbersQuantity];
    for (int i = 0; i < numbersQuantity; i++)
    {
        Console.WriteLine($"Enter number #{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int NumbersOverZeroCounter(int[] array)
{
    int counter = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}

Console.WriteLine($"Numbers over zero quantity: {NumbersOverZeroCounter(InputRequest(NumbersQuantityRequest()))}");

