//Вывести случайное число и показать наибольшую цифру в этом числе

/* int number = new Random().Next(1,99);
int firstValue = number / 10;
int secondValue = number %10;
int max = firstValue;
if (secondValue > max) max = secondValue;

Console.WriteLine(number + " : highest number is " + max); */


//----


//Удалить вторую цифру из числа

/* int number = new Random().Next(100, 1000); 
int result = (number / 100) * 10 +  (number % 10); 
Console.WriteLine("Исходное число: " + number  + ".1 и 3 цифра: " + result); */


//----


//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 ; 16, 4 -> кратно

/* Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// "%" - взятие остатка, как будто делим в столбик и берем остаток( 5 % 3 = 2, 6 % 2 = 0)
if (firstNumber % secondNumber == 0) // Кратно: остатка нет (равен 0)
{
    Console.WriteLine("Кратно!");
}
else // Проверяем, что остаток не равен 0 => есть остаток => число не кратное
{
    Console.WriteLine("Не кратно, остаток от деления равен " +  firstNumber % secondNumber);
}
 */



//-----


Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&": Shift + 7 на англ. раскладке - "И": апельсины и яблоки (берется и апельсины, и яблоки ОДНОВРЕМЕННО)
// "||": Shift + | (на англ.): "ИЛИ": апельсины ИЛИ яблоки (или апельсины, или яблоки, или все вместе)

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно одновременно 7 и 23");
}
