// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3-ех значное число");
int number1 = int.Parse(Console.ReadLine()!);
if (number1 < -999 || number1 > 999)
{
    number1 = number1 / 10 % 10;
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine("Ошибка, вы ввели не 3-ех значное число");
}
