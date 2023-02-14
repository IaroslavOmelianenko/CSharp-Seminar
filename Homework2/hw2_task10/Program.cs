// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int InputRequest()
{
    Console.WriteLine("Input three-digit number :");
    string input = Console.ReadLine();
    int output = Convert.ToInt32(input);
    if (output < 0) output *= -1;
    if (output < 100 || output > 999)
    {
        Console.WriteLine("The number is not three-digit. Please try again.");
        return InputRequest();
    }
    return output;
}

int number = InputRequest();

int secondValue = number % 100 / 10;

Console.WriteLine($"The second value is {secondValue}");
