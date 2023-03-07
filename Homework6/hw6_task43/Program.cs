// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputRequest (string pointName)
{
    double point = 0;
    Console.WriteLine($"Enter point {pointName}: ");
    point = Convert.ToInt32(Console.ReadLine());
    return point;
}

double[] CountLineCrossPoint (double b1, double k1, double b2, double k2)
{
    double[] crossPoint = new double[2];
    crossPoint[0] = (b2-b1) / (k1-k2);
    crossPoint[1] = k1 * (b2-b1) / (k1-k2) + b1;
    return crossPoint;
}

bool LinesCrossCheck (double b1, double k1, double b2, double k2)
{
    bool linesCrossing = true;
    if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Lines are crossing");

    else if (k1 == k2)
    {
        linesCrossing = false;
        Console.WriteLine("Lines are parallel");
    } 
return linesCrossing;
}

double b1 = InputRequest("b1");
double k1 = InputRequest("k1");
double b2 = InputRequest("b2");
double k2 = InputRequest("k2");
Console.WriteLine($"[ b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ]");

if (LinesCrossCheck(b1,k1,b2,k2)){
    double[] crossPoint = CountLineCrossPoint(b1,k1,b2,k2);
    Console.WriteLine($"Lines are crossing at [{crossPoint[0]}, {crossPoint[1]}]");
} 




