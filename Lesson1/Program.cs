//Задача 1

/* bool useRandomNumber;
int number = 0;
string randomRequestAnswer;
askToUseRandom();

if (randomRequestAnswer.Equals("Y"))
{
    number = new Random().Next(1, 10);
}
if (randomRequestAnswer.Equals("N"))
{
    Console.WriteLine("Enter the number: ");
    number = Convert.ToInt32(Console.ReadLine());
}
else
{
    Console.WriteLine("Wrong answer. Please type Y or N");
    askToUseRandom();
}

int result = number * number;
Console.WriteLine("Number = " + number);
Console.WriteLine("Squared number = " + result);


void askToUseRandom()
{
    Console.WriteLine("Do you want to use random number? (Y/N) :");
    randomRequestAnswer = Console.ReadLine();
} */



//Задача 2

/* Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue == Math.Pow(secondValue, 2))

{
    Console.WriteLine("Чиcло " + firstValue + " является квадратом от " + secondValue);
}
else
{
    Console.WriteLine("Чиcло " + firstValue + " НЕ является квадратом от " + secondValue);
} */



//Задача 3

/* Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1);
while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN++;
} */