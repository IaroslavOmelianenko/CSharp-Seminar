// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int ValueRequest(string valueName)
{
    Console.WriteLine($"Enter value {valueName}:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int GetNumbersSum(int start, int end)
{
    if (start == end) return end;
    return (start + GetNumbersSum(start + 1, end));

}

int startNumber = ValueRequest("M");
int endNumber = ValueRequest("N");

Console.WriteLine($"Sum of numbers from {startNumber} to {endNumber}:");
Console.WriteLine(GetNumbersSum(startNumber, endNumber));