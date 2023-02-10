// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}