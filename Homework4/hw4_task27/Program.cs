//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InputRequest ()
{
    Console.WriteLine($"Input number :");
    string input = Console.ReadLine();
    bool isNumber = int.TryParse(input, out int number);
    
    if (!isNumber)
    {
        Console.WriteLine("Not a number. Try again.");
        return InputRequest();
    }

    return number;
}

int SumOfNumbers (int number)
{
    int result = 0;
    for (int i = 0; number > 0; i++)
    {
        result += number%10;
        number /= 10;
    }
    return result;
}

Console.WriteLine($"Sum of numbers is {SumOfNumbers(InputRequest())}");



