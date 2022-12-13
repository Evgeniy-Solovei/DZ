// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num1=int.Parse(Console.ReadLine()!);
int sum = num1%10;
while (num1>0)
{
    num1=num1/10;
    sum=num1%10+sum;
}
// return sum;
Console.Write($"Cумма цифр числа {num1} = {sum}");