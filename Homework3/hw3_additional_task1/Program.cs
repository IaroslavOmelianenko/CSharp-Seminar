// Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными процентами.

double InputRequest()
{
    Console.WriteLine("Input your deposit amount :");
    string input = Console.ReadLine();
    double output;
    bool isNumber = double.TryParse(input, out output);

    if (!isNumber)
    {
        Console.WriteLine("You have typed not only numbers. Try again.");
        return InputRequest();
    }
    return output;
}

double DepositInterestCount(double depositAmount)
{
    double result = depositAmount;
    if (depositAmount < 100) result *= 1.05;
    if (depositAmount >= 100 && depositAmount <= 200) result *= 1.07;
    if (depositAmount > 200) result *= 1.1;
    return result;
}

double depostWithInterest = (Math.Round(DepositInterestCount(InputRequest()), 2));

Console.WriteLine($"Your deposit amount with interest is {depostWithInterest}");