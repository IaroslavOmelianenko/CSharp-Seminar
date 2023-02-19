// Назовем число интересным, если в нем разность максимальной и минимальной цифры равняется средней по величине цифре. Напишите программу, которая определяет интересное число или нет. Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».
//-> 954 - число интересное, средняя цифра - 4, разница: 9 - 5 = 4.
//Средняя цифра - цифра(962-6, 23456 - средняя 4)

string InputRequest()
{
    Console.WriteLine("Input number with even amount of digits :");
    string input = Console.ReadLine();
    bool isNumber = int.TryParse(input, out _);

    if (!isNumber)
    {
        Console.WriteLine("You have typed not only numbers. Try again.");
        return InputRequest();
    }

    if (!HaveMiddleNumberCheck(input))
    {
        Console.WriteLine("Your number must have even amount of digits. Try again.");
        return InputRequest();
    }

    return input;
}


bool HaveMiddleNumberCheck(string inputNumber)
{
    if (inputNumber.Length % 2 == 0) return false;
    else return true;
}


string InterstingNumberCheck(string number)
{
    
    int[] numberAsArray = new int[number.Length];

    for (int i = 0; i < number.Length; i++)
    {
        numberAsArray[i] = Convert.ToInt32(number[i]) - 48;
    }


    int maxNumber = numberAsArray[0];
    int minNumber = numberAsArray[0];
    string result = $"Number {number} is not interesting";

    for (int i = 1; i < numberAsArray.Length; i++)
    {
        if (numberAsArray[i] > maxNumber) maxNumber = numberAsArray[i];
        if (numberAsArray[i] < minNumber) minNumber = numberAsArray[i];
    }

    if (numberAsArray[numberAsArray.Length / 2] == maxNumber - minNumber)
    {
        result = $"Wow! Number {number} is interesting!";
    }
    return result;
}

Console.WriteLine(InterstingNumberCheck(InputRequest()));