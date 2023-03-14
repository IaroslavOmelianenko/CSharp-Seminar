// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ValueRequest(string valueName)
{
    Console.WriteLine($"Enter value {valueName}:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

string GetNumbers(int start, int end)
{
    if (end == start) return end.ToString();
    return (start + "," + GetNumbers(start - 1, end));
}

int endNumber = 1;
int startNumber = ValueRequest("N");

Console.WriteLine($"Numbers from {startNumber} to {endNumber}:");
Console.WriteLine(GetNumbers(startNumber, endNumber));
