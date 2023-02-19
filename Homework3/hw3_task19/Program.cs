// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 12321

string InputRequest(int digitsQuantity)
{
    Console.WriteLine($"Input {digitsQuantity}-digit number :");
    string input = Console.ReadLine();
    bool isNumber = int.TryParse(input, out _);

    if (!isNumber)
    {
        Console.WriteLine("You have typed not only numbers. Try again.");
        return InputRequest(digitsQuantity);
    }
    if (input.Length != digitsQuantity)
    {
        Console.WriteLine($"You have typed more or less than {digitsQuantity} digits. Try again.");
        return InputRequest(digitsQuantity);
    }
    return input;
}

string ReverseString(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

string PalindromeCheck(string checkingVariable)
{
    string result = $"{checkingVariable} is a Palindrome";

    string reversedVariable = ReverseString(checkingVariable);

    for (int i = 0; i < (checkingVariable.Length / 2); i++)
    {
        if (checkingVariable[i] != reversedVariable[i])
        {
            result = $"{checkingVariable} is NOT a Palindrome";   
        }
    }
    return result;
}

Console.WriteLine(PalindromeCheck(InputRequest(5)));