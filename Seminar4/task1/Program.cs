// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int num2 = int.Parse(Console.ReadLine()!);
int count = 0;
int result =1;
while (count < num2)
{
    result=result*num1;
    count++;
}
Console.WriteLine($"{num1} в степени {num2} = {result}");

// Console.WriteLine("Введите число А: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число В: ");
// int num2 = int.Parse(Console.ReadLine()!);
// int sumNum1Num2=(sum)
{
//      int count = 0;
//      int result =1;
//      while (count < num2)
//      {
//         result=result*num1;
//         count++;
//      }
// Console.WriteLine($"{num1} в степени {num2} = {result}");
}



// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число имеет = {SumNumber(num)}");
// int SumNumber(int number)
// {
//     int sum = 0;
//     while (Math.Abs(number) > 0) // модуль числа. Отрицательное, делает положительным
//     {
//         number = number / 10;
//         sum++;
//     }
//     return sum;
// }

// Console.Write("Введите число от 1 до N: ");
// int num = int.Parse(Console.ReadLine()!);

// int CompositionNumbers(int number)
// {
//     int i = 1;
//     int result = 1;
//     while (i <= number)
//     {
//         result = result * i;
//         i++;
//     }
//     return result;
// }
// Console.Write(CompositionNumbers(num));