//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int[] values = new int[3];

Console.Write("Enter FIRST value: ");
values[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter SECOND value: ");
values[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter THIRD value: ");
values[2] = Convert.ToInt32(Console.ReadLine());

int max = values[0];

if (values[1] > max)
{
    max = values[1];
}
if (values[2] > max)
{
    max = values[2];
}

Console.WriteLine("Max value is " + max);
