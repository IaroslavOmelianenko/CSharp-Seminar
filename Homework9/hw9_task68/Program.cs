// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int ValueRequest(string valueName)
{
    Console.WriteLine($"Enter value {valueName}:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ValueRequestForAkkerman(string valueName)
{
    int value = ValueRequest(valueName);
    if (value < 0)
    {
        Console.WriteLine("Numbers for Akkerman Function cant be negative. Try again");
        value = ValueRequest(valueName);
    }
    return value;
}

int GetAkkerman(int n, int m)
{
  while (n != 0)
  {
    if (m == 0) m = 1;
    else m = GetAkkerman(n, m - 1);
    n -=1;
  } 
 return m+1;
}

int mNumber = ValueRequestForAkkerman("m");
int nNumber = ValueRequestForAkkerman("n");

Console.WriteLine($"Akkerman({mNumber}, {nNumber}):");
Console.WriteLine(GetAkkerman(mNumber, nNumber));