// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int InputRequest()
{
    Console.WriteLine("Input the number of day of the week :");
    string input = Console.ReadLine();
    int output = Convert.ToInt32(input);
    if (output > 7 || output < 1)
    {
        Console.WriteLine("It's not a number of day of the week. Please try again.");
        return InputRequest();
    }
    return output;
}

int dayOfWeek = InputRequest();

if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine($"Day#{dayOfWeek} is a weekend. Just relax. The work is not a wolf.");
}
else
{
    Console.WriteLine($"Day#{dayOfWeek} is NOT a weekend! Work is waiting for you!");
}