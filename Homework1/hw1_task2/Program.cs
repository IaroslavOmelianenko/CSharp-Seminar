//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter FIRST value: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter SECOND value: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue > secondValue)
{
    Console.WriteLine("max is " + firstValue + ", min is " + secondValue);
}
if (firstValue < secondValue)
{
    Console.WriteLine("max is " + secondValue + ", min is " + firstValue);
}
if (firstValue == secondValue)
{
    Console.WriteLine("Values are equal");
}
