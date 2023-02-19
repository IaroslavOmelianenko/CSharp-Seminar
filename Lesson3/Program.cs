/* var stringNumber = "_123";
int number; // Если строчка состоит из чисел, то сюда попадает наше число
// TryParse(строчка, out переменная, куда сохраняется результат перевода)
bool isNumber = int.TryParse(stringNumber, out number); // True - cтрочка состоит из чисел, False - пр-т буквы, спецсимволы
if (isNumber) // isNumber == true
{
    Console.WriteLine("Перевод произошел успешно,в стрчоке находились ТОЛЬКО цифры");
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Перевод провалился: в строчке есть не только цифры");
    Console.WriteLine(number);
} */
// TryParse - преобразование строчки в формат числа. 
// Если в строчке присутсвутют ТОЛЬКО цифры, то проверка на строчку проходит успешно
// Если в строчке присутсвутют НЕ ТОЛЬКО цифры, в переменную 0


//-----


//Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/* Console.Write("Введите координату по оси Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());
// A(x; y)
if (x > 0 && y > 0)
{
    Console.WriteLine("Четверть: I");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Четверть: II");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("Четверть: III");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четверть: IV");
}
else
{
    Console.WriteLine("Попаданиние на ось");
} */



//------



//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

/* // A(x1;    y1)
Console.Write("Введите координату точки A по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки  A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
// B(x2;    y2)
Console.Write("Введите координату точки B по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
// AB = √(x2 - x1)^2 + (y2 - y1)^2
// Math.Sqrt(25) => 5
// Math.Pow(число, степень) => Math.Pow(4, 2) => 4 возводите во 2 степень = 16
var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2));
Console.WriteLine(Math.Round(result,3)); // До целого числа

// double test = 1.234;
// // Math.Round(число, количество знаков после запятой) => 1.23
// Console.WriteLine(Math.Round(test, 2)); // => 1.23
// A(x1;    y1); B(x2;    y2)
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21 */


//----


//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

/* Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= N)
{
    Console.Write(Math.Pow(i,2) + "\t");
    // \t - четыре пробела
    i++;
} */

// "\n"  - new - перенос на новую строчку
// "\n" =  Console.WriteLine

/* Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// for(начало; условие; увеличение переменной - счетчика)
for(int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 2) + "\t");
} */
