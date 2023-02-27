// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int InputRequest (string numberName)
{
    Console.WriteLine($"Input number {numberName}:");
    string input = Console.ReadLine();
    bool isNumber = int.TryParse(input, out int number);
    
    if (!isNumber)
    {
        Console.WriteLine("Not a number. Try again.");
        return InputRequest(numberName);
    }

    return number;
}

int numberExponentation (int numberA, int numberB)
{
    int result = numberA;
    for (int i = 2; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

int numberA = InputRequest("A");
int numberB = InputRequest("B");
Console.WriteLine($"{numberA} to the {numberB} degree is {numberExponentation(numberA, numberB)}");