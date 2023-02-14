// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Цифра третья может быть как с левой стороны, так и с правой.

int InputRequest()
{
    Console.WriteLine("Input three-digit number :");
    string input = Console.ReadLine();
    int output = Convert.ToInt32(input);
    if (output < 0) output *= -1;
    if (output < 100)
    {
        Console.WriteLine("There is no third value. Please try again.");
        return InputRequest();
    }

    return output;
}

int GetThirdValueFromLeft(int numberToWorkWith)
{
    while (numberToWorkWith > 999) numberToWorkWith /= 10;

    return numberToWorkWith % 10;
}

int GetThirdValueFromRight(int numberToWorkWith)
{
    return numberToWorkWith % 1000 / 100;
}

int number = InputRequest();
int thirdValueLeft = GetThirdValueFromLeft(number);
int thirdValueRight = GetThirdValueFromRight(number);

Console.WriteLine($"The third value from left is {thirdValueLeft}");
Console.WriteLine($"The third value from right is {thirdValueRight}");
